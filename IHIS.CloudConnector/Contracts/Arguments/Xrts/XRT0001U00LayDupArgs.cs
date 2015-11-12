using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0001U00LayDupArgs : IContractArgs
    {
        private String _xrayCode;

        public String XrayCode
        {
            get { return this._xrayCode; }
            set { this._xrayCode = value; }
        }

        public XRT0001U00LayDupArgs() { }

        public XRT0001U00LayDupArgs(String xrayCode)
        {
            this._xrayCode = xrayCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0001U00LayDupRequest();
        }
    }
}