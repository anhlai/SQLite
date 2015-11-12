using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0003U01LayDupCheckArgs : IContractArgs
    {
        private String _mapGubun;
        private String _mapGubunYmd;

        public String MapGubun
        {
            get { return this._mapGubun; }
            set { this._mapGubun = value; }
        }

        public String MapGubunYmd
        {
            get { return this._mapGubunYmd; }
            set { this._mapGubunYmd = value; }
        }

        public IFS0003U01LayDupCheckArgs() { }

        public IFS0003U01LayDupCheckArgs(String mapGubun, String mapGubunYmd)
        {
            this._mapGubun = mapGubun;
            this._mapGubunYmd = mapGubunYmd;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0003U01LayDupCheckRequest();
        }
    }
}