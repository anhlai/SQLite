using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U21ControlDataValidatingArgs : IContractArgs
    {
        private String _hospCode;
        private String _doctor;
        private String _bunho;
        private String _naewonDate;
        private String _loginDoctorYn;
        private String _gwa;
        private String _ioGubun;
        private String _userId;
        private String _insteadYn;
        private String _approveYn;
        private String _key;
        private String _dataValue;
        private OCS2015U21SelectedPatientInfo _selectedPaInfo;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Doctor
        {
            get { return this._doctor; }
            set { this._doctor = value; }
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

        public String LoginDoctorYn
        {
            get { return this._loginDoctorYn; }
            set { this._loginDoctorYn = value; }
        }

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String InsteadYn
        {
            get { return this._insteadYn; }
            set { this._insteadYn = value; }
        }

        public String ApproveYn
        {
            get { return this._approveYn; }
            set { this._approveYn = value; }
        }

        public String Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        public String DataValue
        {
            get { return this._dataValue; }
            set { this._dataValue = value; }
        }

        public OCS2015U21SelectedPatientInfo SelectedPaInfo
        {
            get { return this._selectedPaInfo; }
            set { this._selectedPaInfo = value; }
        }

        public OCS2015U21ControlDataValidatingArgs() { }

        public OCS2015U21ControlDataValidatingArgs(String hospCode, String doctor, String bunho, String naewonDate, String loginDoctorYn, String gwa, String ioGubun, String userId, String insteadYn, String approveYn, String key, String dataValue, OCS2015U21SelectedPatientInfo selectedPaInfo)
        {
            this._hospCode = hospCode;
            this._doctor = doctor;
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._loginDoctorYn = loginDoctorYn;
            this._gwa = gwa;
            this._ioGubun = ioGubun;
            this._userId = userId;
            this._insteadYn = insteadYn;
            this._approveYn = approveYn;
            this._key = key;
            this._dataValue = dataValue;
            this._selectedPaInfo = selectedPaInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U21ControlDataValidatingRequest();
        }
    }
}