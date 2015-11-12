using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0001U00PrCheckDupArgs : IContractArgs
    {
        private String _masterCheck;
        private String _codeType;
        private String _code;

        public String MasterCheck
        {
            get { return this._masterCheck; }
            set { this._masterCheck = value; }
        }

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

        public IFS0001U00PrCheckDupArgs() { }

        public IFS0001U00PrCheckDupArgs(String masterCheck, String codeType, String code)
        {
            this._masterCheck = masterCheck;
            this._codeType = codeType;
            this._code = code;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0001U00PrCheckDupRequest();
        }
    }
}