using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04GrdPatientListArgs : IContractArgs
    {
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _bunho;
        private String _jubsuGubun;
        private String _jinryoYn;
        private String _naewonYn;
        private String _sysId;

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

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String JubsuGubun
        {
            get { return this._jubsuGubun; }
            set { this._jubsuGubun = value; }
        }

        public String JinryoYn
        {
            get { return this._jinryoYn; }
            set { this._jinryoYn = value; }
        }

        public String NaewonYn
        {
            get { return this._naewonYn; }
            set { this._naewonYn = value; }
        }

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public PHY2001U04GrdPatientListArgs() { }

        public PHY2001U04GrdPatientListArgs(String naewonDate, String gwa, String doctor, String bunho, String jubsuGubun, String jinryoYn, String naewonYn, String sysId)
        {
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._bunho = bunho;
            this._jubsuGubun = jubsuGubun;
            this._jinryoYn = jinryoYn;
            this._naewonYn = naewonYn;
            this._sysId = sysId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04GrdPatientListRequest();
        }
    }
}