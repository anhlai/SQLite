using System;
using IHIS.CloudConnector.Contracts.Models.Xrts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
    public class XRT0001U00GrdXRTArgs : IContractArgs
    {
        private String _txtParam;
        private String _xrayGubun;
        private String _specialYn;

        public String TxtParam
        {
            get { return this._txtParam; }
            set { this._txtParam = value; }
        }

        public String XrayGubun
        {
            get { return this._xrayGubun; }
            set { this._xrayGubun = value; }
        }

        public String SpecialYn
        {
            get { return this._specialYn; }
            set { this._specialYn = value; }
        }

        public XRT0001U00GrdXRTArgs() { }

        public XRT0001U00GrdXRTArgs(String txtParam, String xrayGubun, String specialYn)
        {
            this._txtParam = txtParam;
            this._xrayGubun = xrayGubun;
            this._specialYn = specialYn;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.XRT0001U00GrdXRTRequest();
        }
    }
}