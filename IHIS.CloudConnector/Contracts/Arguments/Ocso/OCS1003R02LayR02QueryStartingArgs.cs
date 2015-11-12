using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCS1003R02LayR02QueryStartingArgs : IContractArgs
    {
        private String _gwa;
        private String _bunho;
        private String _naewonDate;
        private String _doctor;
        private String _naewonType;
        private String _jubsuNo;
        private String _fkout1001;
        private String _userId;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String NaewonType
        {
            get { return this._naewonType; }
            set { this._naewonType = value; }
        }

        public String JubsuNo
        {
            get { return this._jubsuNo; }
            set { this._jubsuNo = value; }
        }

        public String Fkout1001
        {
            get { return this._fkout1001; }
            set { this._fkout1001 = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public OCS1003R02LayR02QueryStartingArgs() { }

        public OCS1003R02LayR02QueryStartingArgs(String gwa, String bunho, String naewonDate, String doctor, String naewonType, String jubsuNo, String fkout1001, String userId)
        {
            this._gwa = gwa;
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._doctor = doctor;
            this._naewonType = naewonType;
            this._jubsuNo = jubsuNo;
            this._fkout1001 = fkout1001;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS1003R02LayR02QueryStartingRequest();
        }
    }
}