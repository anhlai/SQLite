using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00CboInputControlArgs : IContractArgs
    {
        private String _hospCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00CboInputControlArgs() { }

        public OCS0103U00CboInputControlArgs(String hospCode)
        {
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00CboInputControlRequest();
        }
    }
}