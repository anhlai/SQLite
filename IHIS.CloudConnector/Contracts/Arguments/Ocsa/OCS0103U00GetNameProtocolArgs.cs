using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GetNameProtocolArgs : IContractArgs
    {
        private String _hospCode;
        private String _protocolCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String ProtocolCode
        {
            get { return this._protocolCode; }
            set { this._protocolCode = value; }
        }

        public OCS0103U00GetNameProtocolArgs() { }

        public OCS0103U00GetNameProtocolArgs(String hospCode, String protocolCode)
        {
            this._hospCode = hospCode;
            this._protocolCode = protocolCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GetNameProtocolRequest();
        }
    }
}