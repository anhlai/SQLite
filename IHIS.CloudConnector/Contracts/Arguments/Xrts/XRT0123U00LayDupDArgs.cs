using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0123U00LayDupDArgs : IContractArgs
    {
        private String _xrayGubun;
        private String _buwiCode;

        public String XrayGubun
        {
            get { return this._xrayGubun; }
            set { this._xrayGubun = value; }
        }

        public String BuwiCode
        {
            get { return this._buwiCode; }
            set { this._buwiCode = value; }
        }

        public XRT0123U00LayDupDArgs() { }

        public XRT0123U00LayDupDArgs(String xrayGubun, String buwiCode)
        {
            this._xrayGubun = xrayGubun;
            this._buwiCode = buwiCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0123U00LayDupDRequest();
        }
    }
}