using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class FwServiceConnectArgs : IContractArgs
    {
        private String _dbKind;

        public String DbKind
        {
            get { return this._dbKind; }
            set { this._dbKind = value; }
        }

        public FwServiceConnectArgs() { }

        public FwServiceConnectArgs(String dbKind)
        {
            this._dbKind = dbKind;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.FwServiceConnectRequest();
        }
    }
}