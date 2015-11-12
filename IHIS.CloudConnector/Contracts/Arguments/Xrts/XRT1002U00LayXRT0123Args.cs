using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT1002U00LayXRT0123Args : IContractArgs
    {
        private String _buwiCode;
        private String _xrayGubun;

        public String BuwiCode
        {
            get { return this._buwiCode; }
            set { this._buwiCode = value; }
        }

        public String XrayGubun
        {
            get { return this._xrayGubun; }
            set { this._xrayGubun = value; }
        }

        public XRT1002U00LayXRT0123Args() { }

        public XRT1002U00LayXRT0123Args(String buwiCode, String xrayGubun)
        {
            this._buwiCode = buwiCode;
            this._xrayGubun = xrayGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT1002U00LayXRT0123Request();
        }
    }
}