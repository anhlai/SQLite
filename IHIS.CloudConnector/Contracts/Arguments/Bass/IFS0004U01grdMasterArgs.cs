using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0004U01grdMasterArgs : IContractArgs
    {
        private String _nuGubun;
        private String _nuYmd;

        public String NuGubun
        {
            get { return this._nuGubun; }
            set { this._nuGubun = value; }
        }

        public String NuYmd
        {
            get { return this._nuYmd; }
            set { this._nuYmd = value; }
        }

        public IFS0004U01grdMasterArgs() { }

        public IFS0004U01grdMasterArgs(String nuGubun, String nuYmd)
        {
            this._nuGubun = nuGubun;
            this._nuYmd = nuYmd;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0004U01grdMasterRequest();
        }
    }
}