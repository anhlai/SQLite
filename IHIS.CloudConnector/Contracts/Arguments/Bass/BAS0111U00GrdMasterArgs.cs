using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00GrdMasterArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fJohapGubun;
        private String _fJohap;
        private String _fNaewonDate;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FJohapGubun
        {
            get { return this._fJohapGubun; }
            set { this._fJohapGubun = value; }
        }

        public String FJohap
        {
            get { return this._fJohap; }
            set { this._fJohap = value; }
        }

        public String FNaewonDate
        {
            get { return this._fNaewonDate; }
            set { this._fNaewonDate = value; }
        }

        public BAS0111U00GrdMasterArgs() { }

        public BAS0111U00GrdMasterArgs(String fHospCode, String fJohapGubun, String fJohap, String fNaewonDate)
        {
            this._fHospCode = fHospCode;
            this._fJohapGubun = fJohapGubun;
            this._fJohap = fJohap;
            this._fNaewonDate = fNaewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00GrdMasterRequest();
        }
    }
}