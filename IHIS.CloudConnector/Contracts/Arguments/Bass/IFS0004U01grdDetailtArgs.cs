using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0004U01grdDetailtArgs : IContractArgs
    {
        private String _curYmd;
        private String _nuGubun;
        private String _nuCode;
        private String _nuYmd;

        public String CurYmd
        {
            get { return this._curYmd; }
            set { this._curYmd = value; }
        }

        public String NuGubun
        {
            get { return this._nuGubun; }
            set { this._nuGubun = value; }
        }

        public String NuCode
        {
            get { return this._nuCode; }
            set { this._nuCode = value; }
        }

        public String NuYmd
        {
            get { return this._nuYmd; }
            set { this._nuYmd = value; }
        }

        public IFS0004U01grdDetailtArgs() { }

        public IFS0004U01grdDetailtArgs(String curYmd, String nuGubun, String nuCode, String nuYmd)
        {
            this._curYmd = curYmd;
            this._nuGubun = nuGubun;
            this._nuCode = nuCode;
            this._nuYmd = nuYmd;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0004U01grdDetailtRequest();
        }
    }
}