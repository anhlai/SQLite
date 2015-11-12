using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0001U00GrdChangeArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fSlipCode;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FSlipCode
        {
            get { return this._fSlipCode; }
            set { this._fSlipCode = value; }
        }

        public CPL0001U00GrdChangeArgs() { }

        public CPL0001U00GrdChangeArgs(String fHospCode, String fSlipCode)
        {
            this._fHospCode = fHospCode;
            this._fSlipCode = fSlipCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0001U00GrdChangeRequest();
        }
    }
}