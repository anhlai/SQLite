using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U01GrdIFS0003GridFindClickArgs : IContractArgs
    {
        private String _mapGubun;

        public String MapGubun
        {
            get { return this._mapGubun; }
            set { this._mapGubun = value; }
        }

        public IFS0003U01GrdIFS0003GridFindClickArgs() { }

        public IFS0003U01GrdIFS0003GridFindClickArgs(String mapGubun)
        {
            this._mapGubun = mapGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U01GrdIFS0003GridFindClickRequest();
        }
    }
}