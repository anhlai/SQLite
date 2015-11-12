using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class PatientInfoLoadPatientNaewonListArgs : IContractArgs
    {
        private String _bunho;
        private String _naewonDateBase;
        private String _approveDoctor;
        private String _doctorModeYn;
        private String _ioGubun;
        private String _pkKeyOut;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _jaewonFlag;
        private String _pkKeyInp;
        private String _isEnableIpwonReser;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String NaewonDateBase
        {
            get { return this._naewonDateBase; }
            set { this._naewonDateBase = value; }
        }

        public String ApproveDoctor
        {
            get { return this._approveDoctor; }
            set { this._approveDoctor = value; }
        }

        public String DoctorModeYn
        {
            get { return this._doctorModeYn; }
            set { this._doctorModeYn = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
        }

        public String PkKeyOut
        {
            get { return this._pkKeyOut; }
            set { this._pkKeyOut = value; }
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

        public String JaewonFlag
        {
            get { return this._jaewonFlag; }
            set { this._jaewonFlag = value; }
        }

        public String PkKeyInp
        {
            get { return this._pkKeyInp; }
            set { this._pkKeyInp = value; }
        }

        public String IsEnableIpwonReser
        {
            get { return this._isEnableIpwonReser; }
            set { this._isEnableIpwonReser = value; }
        }

        public PatientInfoLoadPatientNaewonListArgs() { }

        public PatientInfoLoadPatientNaewonListArgs(String bunho, String naewonDateBase, String approveDoctor, String doctorModeYn, String ioGubun, String pkKeyOut, String naewonDate, String gwa, String doctor, String jaewonFlag, String pkKeyInp, String isEnableIpwonReser)
        {
            this._bunho = bunho;
            this._naewonDateBase = naewonDateBase;
            this._approveDoctor = approveDoctor;
            this._doctorModeYn = doctorModeYn;
            this._ioGubun = ioGubun;
            this._pkKeyOut = pkKeyOut;
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._jaewonFlag = jaewonFlag;
            this._pkKeyInp = pkKeyInp;
            this._isEnableIpwonReser = isEnableIpwonReser;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PatientInfoLoadPatientNaewonListRequest();
        }
    }
}