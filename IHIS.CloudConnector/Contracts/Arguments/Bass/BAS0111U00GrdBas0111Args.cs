using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00GrdBas0111Args : IContractArgs
    {
        private String _fHospCode;
        private String _fJohapGubun;
        private String _fJohap;

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

        public BAS0111U00GrdBas0111Args() { }

        public BAS0111U00GrdBas0111Args(String fHospCode, String fJohapGubun, String fJohap)
        {
            this._fHospCode = fHospCode;
            this._fJohapGubun = fJohapGubun;
            this._fJohap = fJohap;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00GrdBas0111Request();
        }
    }
}