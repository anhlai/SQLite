using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0101U01GrdDcodeArgs : IContractArgs
    {
        private String _codeType;
        private String _code;
        private String _codeName;

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

        public String CodeName
        {
            get { return this._codeName; }
            set { this._codeName = value; }
        }

        public XRT0101U01GrdDcodeArgs() { }

        public XRT0101U01GrdDcodeArgs(String codeType, String code, String codeName)
        {
            this._codeType = codeType;
            this._code = code;
            this._codeName = codeName;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0101U01GrdDcodeRequest();
        }
    }
}