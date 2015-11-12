using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class ComBizLoadIFS0001InfoArgs : IContractArgs
    {
        private String _codeType;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
        }

        public ComBizLoadIFS0001InfoArgs() { }

        public ComBizLoadIFS0001InfoArgs(String codeType)
        {
            this._codeType = codeType;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComBizLoadIFS0001InfoRequest();
        }
    }
}