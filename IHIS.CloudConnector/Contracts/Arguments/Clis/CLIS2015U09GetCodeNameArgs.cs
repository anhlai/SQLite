using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U09GetCodeNameArgs : IContractArgs
    {
        private String _code;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public CLIS2015U09GetCodeNameArgs() { }

        public CLIS2015U09GetCodeNameArgs(String code)
        {
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U09GetCodeNameRequest();
        }
    }
}