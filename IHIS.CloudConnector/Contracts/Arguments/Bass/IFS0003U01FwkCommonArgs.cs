using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U01FwkCommonArgs : IContractArgs
    {
        private String _codeType;
        private String _find1;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public IFS0003U01FwkCommonArgs() { }

        public IFS0003U01FwkCommonArgs(String codeType, String find1)
        {
            this._codeType = codeType;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U01FwkCommonRequest();
        }
    }
}