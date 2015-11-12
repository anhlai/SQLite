using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00VzvJohapArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fJohap;
        private String _fStartDate;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FJohap
        {
            get { return this._fJohap; }
            set { this._fJohap = value; }
        }

        public String FStartDate
        {
            get { return this._fStartDate; }
            set { this._fStartDate = value; }
        }

        public BAS0111U00VzvJohapArgs() { }

        public BAS0111U00VzvJohapArgs(String fHospCode, String fJohap, String fStartDate)
        {
            this._fHospCode = fHospCode;
            this._fJohap = fJohap;
            this._fStartDate = fStartDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00VzvJohapRequest();
        }
    }
}