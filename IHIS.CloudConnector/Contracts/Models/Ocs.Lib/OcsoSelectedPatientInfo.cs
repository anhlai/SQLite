using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class OcsoSelectedPatientInfo
    {
        private String _naewonDate;
        private String _bunho;
        private String _suname2;
        private String _suname;
        private String _sex;
        private String _birth;
        private String _zipCode;
        private String _address;
        private String _tel;
        private String _naewonKey;
        private String _gwa;
        private String _doctor;

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Suname2
        {
            get { return this._suname2; }
            set { this._suname2 = value; }
        }

        public String Suname
        {
            get { return this._suname; }
            set { this._suname = value; }
        }

        public String Sex
        {
            get { return this._sex; }
            set { this._sex = value; }
        }

        public String Birth
        {
            get { return this._birth; }
            set { this._birth = value; }
        }

        public String ZipCode
        {
            get { return this._zipCode; }
            set { this._zipCode = value; }
        }

        public String Address
        {
            get { return this._address; }
            set { this._address = value; }
        }

        public String Tel
        {
            get { return this._tel; }
            set { this._tel = value; }
        }

        public String NaewonKey
        {
            get { return this._naewonKey; }
            set { this._naewonKey = value; }
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

        public OcsoSelectedPatientInfo() { }

        public OcsoSelectedPatientInfo(String naewonDate, String bunho, String suname2, String suname, String sex, String birth, String zipCode, String address, String tel, String naewonKey, String gwa, String doctor)
        {
            this._naewonDate = naewonDate;
            this._bunho = bunho;
            this._suname2 = suname2;
            this._suname = suname;
            this._sex = sex;
            this._birth = birth;
            this._zipCode = zipCode;
            this._address = address;
            this._tel = tel;
            this._naewonKey = naewonKey;
            this._gwa = gwa;
            this._doctor = doctor;
        }

    }
}