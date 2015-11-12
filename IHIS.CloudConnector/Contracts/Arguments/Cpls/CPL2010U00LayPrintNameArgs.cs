using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL2010U00LayPrintNameArgs : IContractArgs
    {
        private String _ipAddress;

        public String IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        public CPL2010U00LayPrintNameArgs() { }

        public CPL2010U00LayPrintNameArgs(String ipAddress)
        {
            this._ipAddress = ipAddress;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL2010U00LayPrintNameRequest();
        }
    }
}