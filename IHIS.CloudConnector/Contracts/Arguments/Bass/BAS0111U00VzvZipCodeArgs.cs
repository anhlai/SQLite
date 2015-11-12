using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0111U00VzvZipCodeArgs : IContractArgs
    {
        private String _fHospCode;
        private String _fZip1;
        private String _fZip2;

        public String FHospCode
        {
            get { return this._fHospCode; }
            set { this._fHospCode = value; }
        }

        public String FZip1
        {
            get { return this._fZip1; }
            set { this._fZip1 = value; }
        }

        public String FZip2
        {
            get { return this._fZip2; }
            set { this._fZip2 = value; }
        }

        public BAS0111U00VzvZipCodeArgs() { }

        public BAS0111U00VzvZipCodeArgs(String fHospCode, String fZip1, String fZip2)
        {
            this._fHospCode = fHospCode;
            this._fZip1 = fZip1;
            this._fZip2 = fZip2;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0111U00VzvZipCodeRequest();
        }
    }
}