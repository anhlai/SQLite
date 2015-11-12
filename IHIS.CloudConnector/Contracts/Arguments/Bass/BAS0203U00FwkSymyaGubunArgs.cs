using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00FwkSymyaGubunArgs : IContractArgs
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

        public BAS0203U00FwkSymyaGubunArgs() { }

        public BAS0203U00FwkSymyaGubunArgs(String hospCode, String find1)
        {
            this._hospCode = hospCode;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00FwkSymyaGubunRequest();
        }
    }
}