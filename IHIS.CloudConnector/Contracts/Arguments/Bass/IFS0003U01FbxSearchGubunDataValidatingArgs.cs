using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U01FbxSearchGubunDataValidatingArgs : IContractArgs
    {
        private String _codeType;
        private String _code;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public IFS0003U01FbxSearchGubunDataValidatingArgs() { }

        public IFS0003U01FbxSearchGubunDataValidatingArgs(String codeType, String code)
        {
            this._codeType = codeType;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U01FbxSearchGubunDataValidatingRequest();
        }
    }
}