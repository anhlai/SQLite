using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U02CboStatusArgs : IContractArgs
    {
        private Boolean _isAll;

        public Boolean IsAll
        {
            get { return this._isAll; }
            set { this._isAll = value; }
        }

        public CLIS2015U02CboStatusArgs() { }

        public CLIS2015U02CboStatusArgs(Boolean isAll)
        {
            this._isAll = isAll;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U02CboStatusRequest();
        }
    }
}