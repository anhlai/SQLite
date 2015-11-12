using System;
using System.IO;
using System.Net;
using System.Reflection;
using IHIS.CloudConnector.Contracts.Results.System;
using IHIS.CloudConnector.Events;
using IHIS.CloudConnector.Messaging;
using IHIS.Framework;
using System.Collections.Generic;
using ProtoBuf;
using WebSocket4Net;
using ErrorEventArgs = SuperSocket.ClientEngine.ErrorEventArgs;

namespace IHIS.CloudConnector.Socket
{
    public class WebSocketClient
    {
        private static readonly MethodInfo DeserializeMethod = typeof (Serializer).GetMethod("Deserialize");
        private readonly String _socketUrl;
        private WebSocket _websocket;
        private ConnectionStatus _status;
        private static String _sessionId;
        private readonly Dictionary<string, string> _servicesMap;

        public static String SessionId
        {
            set { _sessionId = value; }
            get { return _sessionId; }
        }

        public WebSocketClient(string socketUrl)
        {
            _socketUrl = socketUrl;
            _status = ConnectionStatus.Disconnected;
            _servicesMap = Utility.Utility.CreateServicesMap();
        }

        public string SocketUrl
        {
            get { return _socketUrl; }
        }

        public ConnectionStatus Status
        {
            get { return _status; }
        }

        public ConnectionStatus Connect()
        {
            if (_status == ConnectionStatus.Disconnected)
            {
                _websocket = new WebSocket(_socketUrl);
                _websocket.Opened += websocket_Opened;
                _websocket.Error += websocket_Error;
                _websocket.Closed += websocket_Closed;
                _websocket.DataReceived += websocket_DataReceived;
                _websocket.MessageReceived += _websocket_MessageReceived;
                _websocket.Open();
                _status = ConnectionStatus.Connecting;
                ConnectionEvent eEvent = new ConnectionEvent(_status);
                EventAggregator.Instance.Publish(eEvent);
            }
            return _status;
        }

        public void DisConnect()
        {
            if (_status != ConnectionStatus.Disconnected)
            {
                _websocket.Close();
            }
        }

        private void _websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Console.WriteLine("Message recieved: {0}", e.Message);
        }

        public void websocket_DataReceived(object sender, DataReceivedEventArgs e)
        {
            Console.WriteLine("Data recieved: {0}", e.Data);
            MemoryStream stream = new MemoryStream(e.Data);
            RpcMessage message = Serializer.Deserialize<RpcMessage>(stream);

            Console.WriteLine("Payload Class: {0}", message.payload_class);
            Object payload = RpcMessage.Result.SUCCESS == message.result ? ParsePayload(message.payload_data, message.payload_class) : null;
            //Console.WriteLine(payload.ToString());

            if (payload != null && _sessionId == null && payload.GetType().IsAssignableFrom(typeof(AdmLoginFormCheckLoginUserResponse)))
            {
                AdmLoginFormCheckLoginUserResponse response = (AdmLoginFormCheckLoginUserResponse)payload;
                if (!string.IsNullOrEmpty(response.session_id))
                {
                    _sessionId = response.session_id;
                }
            }

            RpcResult result = new RpcResult(message.source_id, (int)message.result, payload);
            EventAggregator.Instance.Publish(result);
        }

        public void websocket_Closed(object sender, EventArgs e)
        {
            Console.WriteLine("Connection Closed");
            _status = ConnectionStatus.Disconnected;
            ConnectionEvent eEvent = new ConnectionEvent(_status);
            EventAggregator.Instance.Publish(eEvent);
        }

        public void websocket_Error(object sender, ErrorEventArgs e)
        {
            Console.WriteLine("Error: {0}", e.Exception);
        }

        public void websocket_Opened(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_sessionId))
            {
                AdmLoginOnBehalfOfRequest request = new AdmLoginOnBehalfOfRequest();
                request.session_id = _sessionId;
                Send<AdmLoginOnBehalfOfRequest>(request, 0L);
            }
            Console.WriteLine("Connection Connected");
            _status = ConnectionStatus.Connected;
            ConnectionEvent eEvent = new ConnectionEvent(_status);
            EventAggregator.Instance.Publish(eEvent);
        }

        public void Send<T>(T payloadData, long messageId) where T : IExtensible
        {
            String payloadClass = payloadData.GetType().Name;
            string service = _servicesMap[payloadClass];
            RpcMessage message = new RpcMessage();
            message.service = service;
            message.version = "1.0.0";
            message.payload_class = payloadClass;
            message.id = messageId;
            message.client_id = Utility.Utility.GetMacAddress() + "-" + messageId;
            // write log
            Service.WriteLog("ClientID - " + message.client_id);

            MemoryStream stream = new MemoryStream();
            Serializer.Serialize(stream, payloadData);
            message.payload_data = stream.ToArray();

            stream = new MemoryStream();
            Serializer.Serialize(stream, message);
            byte[] data = stream.ToArray();
            _websocket.Send(data, 0, data.Length);
        }

        private Object ParsePayload(byte[] data, String payloadClass)
        {
            if (null == data || null == payloadClass) return null;
            MemoryStream stream = new MemoryStream(data);
            MethodInfo newMethod =
                DeserializeMethod.MakeGenericMethod(Type.GetType("IHIS.CloudConnector.Messaging." + payloadClass));
            return newMethod.Invoke(null, new object[] {stream});
        }
    }
}