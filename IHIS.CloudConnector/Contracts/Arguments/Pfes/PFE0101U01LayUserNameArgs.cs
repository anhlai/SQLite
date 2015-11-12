using System;
using IHIS.CloudConnector.Contracts.Models.Pfes;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
    public class PFE0101U01LayUserNameArgs : IContractArgs
    {
        private String _code;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public PFE0101U01LayUserNameArgs() { }

        public PFE0101U01LayUserNameArgs(String code)
        {
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PFE0101U01LayUserNameRequest();
        }
    }
}