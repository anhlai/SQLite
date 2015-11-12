using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0801U00GetCodeNameArgs : IContractArgs
    {
        private String _codeMode;
        private String _code;
        private String _patStatus;

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

        public String PatStatus
        {
            get { return this._patStatus; }
            set { this._patStatus = value; }
        }

        public OCS0801U00GetCodeNameArgs() { }

        public OCS0801U00GetCodeNameArgs(String codeMode, String code, String patStatus)
        {
            this._codeMode = codeMode;
            this._code = code;
            this._patStatus = patStatus;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0801U00GetCodeNameRequest();
        }
    }
}