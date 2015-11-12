using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00LayHangmogCodeArgs : IContractArgs
    {
        private String _code;
        private String _code2;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String Code2
        {
            get { return this._code2; }
            set { this._code2 = value; }
        }

        public OCS0311U00LayHangmogCodeArgs() { }

        public OCS0311U00LayHangmogCodeArgs(String code, String code2)
        {
            this._code = code;
            this._code2 = code2;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00LayHangmogCodeRequest();
        }
    }
}