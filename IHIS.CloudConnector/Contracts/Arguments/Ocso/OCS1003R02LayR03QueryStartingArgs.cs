using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCS1003R02LayR03QueryStartingArgs : IContractArgs
    {
        private String _gwa;
        private String _bunho;
        private String _naewonDate;
        private String _doctor;
        private String _naewonType;
        private String _jubsuNo;

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

        public OCS1003R02LayR03QueryStartingArgs() { }

        public OCS1003R02LayR03QueryStartingArgs(String gwa, String bunho, String naewonDate, String doctor, String naewonType, String jubsuNo)
        {
            this._gwa = gwa;
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._doctor = doctor;
            this._naewonType = naewonType;
            this._jubsuNo = jubsuNo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS1003R02LayR03QueryStartingRequest();
        }
    }
}