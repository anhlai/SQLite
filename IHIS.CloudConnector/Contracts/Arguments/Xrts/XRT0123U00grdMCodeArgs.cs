using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0123U00grdMCodeArgs : IContractArgs
    {
        private String _xrayGubun;

        public String XrayGubun
        {
            get { return this._xrayGubun; }
            set { this._xrayGubun = value; }
        }

        public XRT0123U00grdMCodeArgs() { }

        public XRT0123U00grdMCodeArgs(String xrayGubun)
        {
            this._xrayGubun = xrayGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0123U00grdMCodeRequest();
        }
    }
}