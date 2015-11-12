using System;

namespace IHIS.CloudConnector.Contracts.Models.OcsEmr
{
    public class OCS2015U21SelectedPatientInfo
    {
        private String _bunho;
        private String _naewonKey;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _approveDoctor;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonKey
        {
            get { return this._naewonKey; }
            set { this._naewonKey = value; }
        }

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String ApproveDoctor
        {
            get { return this._approveDoctor; }
            set { this._approveDoctor = value; }
        }

        public OCS2015U21SelectedPatientInfo() { }

        public OCS2015U21SelectedPatientInfo(String bunho, String naewonKey, String naewonDate, String gwa, String doctor, String approveDoctor)
        {
            this._bunho = bunho;
            this._naewonKey = naewonKey;
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._approveDoctor = approveDoctor;
        }

    }
}