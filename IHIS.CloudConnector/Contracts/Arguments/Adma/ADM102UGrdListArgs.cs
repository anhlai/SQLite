using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM102UGrdListArgs : IContractArgs
    {
        private String _sysId;

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public ADM102UGrdListArgs() { }

        public ADM102UGrdListArgs(String sysId)
        {
            this._sysId = sysId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM102UGrdListRequest();
        }
    }
}