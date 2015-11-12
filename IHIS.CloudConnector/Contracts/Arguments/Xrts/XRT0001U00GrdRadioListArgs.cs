using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0001U00GrdRadioListArgs : IContractArgs
    {
        private String _xrayCode;

        public String XrayCode
        {
            get { return this._xrayCode; }
            set { this._xrayCode = value; }
        }

        public XRT0001U00GrdRadioListArgs() { }

        public XRT0001U00GrdRadioListArgs(String xrayCode)
        {
            this._xrayCode = xrayCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0001U00GrdRadioListRequest();
        }
    }
}