using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U00CheckItemGrdDetailArgs : IContractArgs
    {
        private String _code;
        private String _codeType;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public CPL0108U00CheckItemGrdDetailArgs() { }

        public CPL0108U00CheckItemGrdDetailArgs(String code, String codeType)
        {
            this._code = code;
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U00CheckItemGrdDetailRequest();
        }
    }
}