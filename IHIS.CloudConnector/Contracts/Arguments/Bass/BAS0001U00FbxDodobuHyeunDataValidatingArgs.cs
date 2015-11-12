using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0001U00FbxDodobuHyeunDataValidatingArgs : IContractArgs
    {
        private String _codeType;
        private String _code;
        private String _hospCode;

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

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0001U00FbxDodobuHyeunDataValidatingArgs() { }

        public BAS0001U00FbxDodobuHyeunDataValidatingArgs(String codeType, String code, String hospCode)
        {
            this._codeType = codeType;
            this._code = code;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0001U00FbxDodobuHyeunDataValidatingRequest();
        }
    }
}