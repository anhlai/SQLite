using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04BtnDeleteArgs : IContractArgs
    {
        private String _user;
        private String _naewonDate;
        private String _bunho;
        private String _gwa;
        private String _gubun;
        private String _tuyakIlsu;
        private String _doctor;
        private String _inOut;
        private String _chartGwa;
        private String _specialYn;
        private String _toiwonDate;

        public String User
        {
            get { return this._user; }
            set { this._user = value; }
        }

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

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

        public String TuyakIlsu
        {
            get { return this._tuyakIlsu; }
            set { this._tuyakIlsu = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
        }

        public String InOut
        {
            get { return this._inOut; }
            set { this._inOut = value; }
        }

        public String ChartGwa
        {
            get { return this._chartGwa; }
            set { this._chartGwa = value; }
        }

        public String SpecialYn
        {
            get { return this._specialYn; }
            set { this._specialYn = value; }
        }

        public String ToiwonDate
        {
            get { return this._toiwonDate; }
            set { this._toiwonDate = value; }
        }

        public PHY2001U04BtnDeleteArgs() { }

        public PHY2001U04BtnDeleteArgs(String user, String naewonDate, String bunho, String gwa, String gubun, String tuyakIlsu, String doctor, String inOut, String chartGwa, String specialYn, String toiwonDate)
        {
            this._user = user;
            this._naewonDate = naewonDate;
            this._bunho = bunho;
            this._gwa = gwa;
            this._gubun = gubun;
            this._tuyakIlsu = tuyakIlsu;
            this._doctor = doctor;
            this._inOut = inOut;
            this._chartGwa = chartGwa;
            this._specialYn = specialYn;
            this._toiwonDate = toiwonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04BtnDeleteRequest();
        }
    }
}