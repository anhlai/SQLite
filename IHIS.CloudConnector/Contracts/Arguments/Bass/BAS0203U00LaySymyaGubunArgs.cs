using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00LaySymyaGubunArgs : IContractArgs
    {
        private String _hospCode;
        private String _code;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public BAS0203U00LaySymyaGubunArgs() { }

        public BAS0203U00LaySymyaGubunArgs(String hospCode, String code)
        {
            this._hospCode = hospCode;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00LaySymyaGubunRequest();
        }
    }
}