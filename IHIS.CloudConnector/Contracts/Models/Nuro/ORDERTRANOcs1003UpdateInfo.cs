using System;

namespace IHIS.CloudConnector.Contracts.Models.Nuro
{
    public class ORDERTRANOcs1003UpdateInfo
    {
        private String _sunabDate;
        private String _fkout1003;
        private String _hospCode;
        private String _pkocs1003;
        private String _bunho;
        private String _actingDate;
        private String _gubun;
        private String _gwa;
        private String _doctor;
        private String _pk;

        public String SunabDate
        {
            get { return this._sunabDate; }
            set { this._sunabDate = value; }
        }

        public String Fkout1003
        {
            get { return this._fkout1003; }
            set { this._fkout1003 = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Pkocs1003
        {
            get { return this._pkocs1003; }
            set { this._pkocs1003 = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
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

        public String Pk
        {
            get { return this._pk; }
            set { this._pk = value; }
        }

        public ORDERTRANOcs1003UpdateInfo() { }

        public ORDERTRANOcs1003UpdateInfo(String sunabDate, String fkout1003, String hospCode, String pkocs1003, String bunho, String actingDate, String gubun, String gwa, String doctor, String pk)
        {
            this._sunabDate = sunabDate;
            this._fkout1003 = fkout1003;
            this._hospCode = hospCode;
            this._pkocs1003 = pkocs1003;
            this._bunho = bunho;
            this._actingDate = actingDate;
            this._gubun = gubun;
            this._gwa = gwa;
            this._doctor = doctor;
            this._pk = pk;
        }

    }
}