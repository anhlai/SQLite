using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;
using System.Text;
using System.Threading;
using IHIS.CloudConnector.Contracts.Arguments;
using IHIS.CloudConnector.Contracts.Results;
using IHIS.CloudConnector.Contracts.Results.System;
using IHIS.CloudConnector.Events;
using IHIS.CloudConnector.Mappings;
using IHIS.CloudConnector.Socket;
using IHIS.Framework;
using ProtoBuf;

namespace IHIS.CloudConnector
{
    public class CloudService
    {
        private static readonly CloudService _instance = new CloudService();
        private readonly WebSocketClient _socketClient;
        private readonly object _globalLock = new object();
        private long _messageCounter = 0;
        private readonly Dictionary<long, Tuple<object, RpcResult>> _syncMessages = new Dictionary<long, Tuple<object, RpcResult>>();
        private static readonly MethodInfo MapMethod = GetMapMethod();
        private readonly Dictionary<string, long> _timeoutSpecial; 

        private static MethodInfo GetMapMethod()
        {
            foreach (MethodInfo method in typeof(Mapper).GetMethods())
            {
                if (method.GetParameters().Length == 2 && method.IsGenericMethod && method.Name.Equals("Map"))
                {
                    return method;
                }
            }
            throw new InvalidOperationException("Can't find method Map");
        }

        public static CloudService Instance
        {
            get { return _instance; }
        }

        private CloudService()
        {
            // socketClient = new WebSocketClient(Service.GetConfigString("CLOUD", "URL", "ws://localhost:8890"), Service.GetConfigString("CLOUD", "SERVICE", "MED"), Service.GetConfigString("CLOUD", "VERSION", "1234"));
            Console.WriteLine("Init CloudService instance");
            // _socketClient = new WebSocketClient(Service.GetConfigString("CLOUD", "URL", "wss://nfx.posismo.com:8890"), Service.GetConfigString("CLOUD", "SERVICE", "Socket"), Service.GetConfigString("CLOUD", "VERSION", "38868"));

            String socketUrl = ConfigurationManager.AppSettings["SocketUrl"];
            _socketClient = new WebSocketClient(socketUrl);
            _timeoutSpecial = Utility.Utility.CreateTimeOutSpecial();

            EventAggregator.Instance.Subscribe<ConnectionEvent>(OnConnectionStatusChanged);
            EventAggregator.Instance.Subscribe<RpcResult>(OnMessageReceived);
        }

        private void OnMessageReceived(RpcResult rpcResult)
        {
            if (_syncMessages.ContainsKey(rpcResult.Id))
            {
                Tuple<object, RpcResult> result;
                _syncMessages.TryGetValue(rpcResult.Id, out result);
                if (result != null)
                {
                    result.Value2 = rpcResult;
                    lock (result.Value1)
                    {
                        Monitor.PulseAll(result.Value1);
                    }
                }
            }
        }

        private void OnConnectionStatusChanged(ConnectionEvent connectionEvent)
        {
            if (connectionEvent.Status != ConnectionStatus.Connecting)
                lock (_globalLock)
                {
                    Monitor.PulseAll(_globalLock);
                }
        }

        public bool Connect()
        {
            try
            {
                ConnectionStatus status = _socketClient.Connect();
                if (status != ConnectionStatus.Connected)
                {
                    lock (_globalLock)
                    {
                        Service.WriteLog("Connecting to server...");
                        Monitor.Wait(_globalLock,
                            new TimeSpan(int.Parse(ConfigurationManager.AppSettings["ConnectionTimeout"])));
                    }
                }
                Service.WriteLog("Connected");
                return _socketClient.Status == ConnectionStatus.Connected;
            }
            catch (Exception e)
            {
                Service.WriteLog("Exception: " + e.StackTrace);
                return false;
            }
        }

        public TR Submit<TR, TA>(TA args)
            where TR : IContractResult
            where TA : class, IContractArgs
        {
            Tuple<object, RpcResult> result = null;
            try
            {
                IExtensible request = args.GetRequestInstance();
                MethodInfo newMethod = MapMethod.MakeGenericMethod(request.GetType(), typeof(TA));
                newMethod.Invoke(Mapper.Instance, new object[] { request, args });
                long messageId = Interlocked.Increment(ref _messageCounter);
                object _lock = new object();
                _syncMessages.Add(messageId, new Tuple<object, RpcResult>(_lock, null));
                lock (_lock)
                {
                    Service.WriteLog("[SEND] - " + args.GetType());
                    _socketClient.Send(request, messageId);
                    if (_timeoutSpecial.ContainsKey(request.GetType().Name))
                    {
                        long timeout;
                        _timeoutSpecial.TryGetValue(request.GetType().Name, out timeout);
                        Monitor.Wait(_lock, new TimeSpan(timeout));
                    }
                    else
                    {
                        Monitor.Wait(_lock, new TimeSpan(Convert.ToInt64(ConfigurationManager.AppSettings["RequestTimeout"])));
                    }
                }
                _syncMessages.TryGetValue(messageId, out result);
                _syncMessages.Remove(messageId);
                if (result == null || result.Value2 == null)
                {
                    Service.WriteLog("[RECEIVE] - Result is NULL");
                    return Activator.CreateInstance<TR>();
                }

                // write log
                StringBuilder logReceiveMsgSb = new StringBuilder("[RECEIVE] - ");
                if (result.Value2.GetPayload<TR>().ExecutionStatus == ExecutionStatus.Success)
                    logReceiveMsgSb.Append("SUCCESS");
                else if (result.Value2.GetPayload<TR>().ExecutionStatus == ExecutionStatus.Failure)
                    logReceiveMsgSb.Append("FAILURE");
                else if (result.Value2.GetPayload<TR>().ExecutionStatus == ExecutionStatus.Timeout)
                    logReceiveMsgSb.Append("TIMEOUT");
                else logReceiveMsgSb.Append("UNKNOWN");
                logReceiveMsgSb.Append(" - ");
                logReceiveMsgSb.Append(result.Value2.GetPayload<TR>().GetType());
                Service.WriteLog(logReceiveMsgSb.ToString());
                return result.Value2.GetPayload<TR>();
            }
            catch (Exception e)
            {
                Service.WriteLog("Exception: " + e.StackTrace);
                if (result == null || result.Value2 == null)
                {
                    return Activator.CreateInstance<TR>();
                }
                return result.Value2.GetPayload<TR>();
            }
        }

        public void Execute<TA>(TA args)
            where TA : class, IContractArgs
        {
            IExtensible request = args.GetRequestInstance();
            MethodInfo newMethod = MapMethod.MakeGenericMethod(request.GetType(), typeof(TA));
            newMethod.Invoke(Mapper.Instance, new object[] { request, args });
            //Mapper.Instance.Map(request, args);
            _socketClient.Send(request, Interlocked.Increment(ref _messageCounter));
        }
    }

    class Tuple<T1, T2>
    {
        private T1 _value1;
        private T2 _value2;

        public Tuple(T1 value1, T2 value2)
        {
            _value1 = value1;
            _value2 = value2;
        }

        public T1 Value1
        {
            get { return _value1; }
            set { _value1 = value; }
        }

        public T2 Value2
        {
            get { return _value2; }
            set { _value2 = value; }
        }
    }
}