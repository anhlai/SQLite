using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00GetProtocolArgs : IContractArgs
    {
        private String _hospCode;
        private String _find1;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public OCS0103U00GetProtocolArgs() { }

        public OCS0103U00GetProtocolArgs(String hospCode, String find1)
        {
            this._hospCode = hospCode;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00GetProtocolRequest();
        }
    }
}