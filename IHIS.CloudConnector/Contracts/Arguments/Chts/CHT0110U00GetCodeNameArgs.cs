using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0110U00GetCodeNameArgs : IContractArgs
    {
        private String _codeMode;
        private String _code;

        public String CodeMode
        {
            get { return this._codeMode; }
            set { this._codeMode = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public CHT0110U00GetCodeNameArgs() { }

        public CHT0110U00GetCodeNameArgs(String codeMode, String code)
        {
            this._codeMode = codeMode;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0110U00GetCodeNameRequest();
        }
    }
}