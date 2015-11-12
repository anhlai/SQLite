using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0311U00laySetHangmogArgs : IContractArgs
    {
        private String _code;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public OCS0311U00laySetHangmogArgs() { }

        public OCS0311U00laySetHangmogArgs(String code)
        {
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0311U00laySetHangmogRequest();
        }
    }
}