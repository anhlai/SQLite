using System;
using IHIS.CloudConnector.Contracts.Models;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class LogonArgs : IContractArgs
    {
        private string _ticket;
        private string _customerId;
        private string _target;
        private string _serviceType;

        public string Ticket
        {
            get { return _ticket; }
            set { _ticket = value; }
        }

        public string CustomerId
        {
            get { return _customerId; }
            set { _customerId = value; }
        }

        public string Target
        {
            get { return _target; }
            set { _target = value; }
        }

        public string ServiceType
        {
            get { return _serviceType; }
            set { _serviceType = value; }
        }

        public LogonArgs(String ticket, String customerId, String target, String serviceType)
        {
            Ticket = ticket;
            CustomerId = customerId;
            Target = target;
            ServiceType = serviceType;
        }

        public LogonArgs()
        {
        }

        public IExtensible GetRequestInstance()
        {
            return new LogonRequest();
        }
    }
}