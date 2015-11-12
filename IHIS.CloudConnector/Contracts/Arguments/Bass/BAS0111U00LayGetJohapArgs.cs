using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00LayGetJohapArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fGubun;
        private String _fNaewonDate;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FGubun
        {
            get { return this._fGubun; }
            set { this._fGubun = value; }
        }

        public String FNaewonDate
        {
            get { return this._fNaewonDate; }
            set { this._fNaewonDate = value; }
        }

        public BAS0111U00LayGetJohapArgs() { }

        public BAS0111U00LayGetJohapArgs(String fHospCode, String fGubun, String fNaewonDate)
        {
            this._fHospCode = fHospCode;
            this._fGubun = fGubun;
            this._fNaewonDate = fNaewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00LayGetJohapRequest();
        }
    }
}