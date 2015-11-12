using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04CreateAutoJubsuArgs : IContractArgs
    {
        private String _pkout1001;
        private String _gwa;
        private String _doctor;
        private String _jubsuGubun;
        private String _userId;
        private String _bunho;
        private String _naewonDate;
        private String _orderDate;
        private String _fkout1001;
        private String _sinryouryouGubun;
        private String _inputId;
        private String _inputTab;
        private String _iudGubun;
        private Boolean _cbxSinryouryou;

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
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

        public String JubsuGubun
        {
            get { return this._jubsuGubun; }
            set { this._jubsuGubun = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
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

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String Fkout1001
        {
            get { return this._fkout1001; }
            set { this._fkout1001 = value; }
        }

        public String SinryouryouGubun
        {
            get { return this._sinryouryouGubun; }
            set { this._sinryouryouGubun = value; }
        }

        public String InputId
        {
            get { return this._inputId; }
            set { this._inputId = value; }
        }

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public String IudGubun
        {
            get { return this._iudGubun; }
            set { this._iudGubun = value; }
        }

        public Boolean CbxSinryouryou
        {
            get { return this._cbxSinryouryou; }
            set { this._cbxSinryouryou = value; }
        }

        public PHY2001U04CreateAutoJubsuArgs() { }

        public PHY2001U04CreateAutoJubsuArgs(String pkout1001, String gwa, String doctor, String jubsuGubun, String userId, String bunho, String naewonDate, String orderDate, String fkout1001, String sinryouryouGubun, String inputId, String inputTab, String iudGubun, Boolean cbxSinryouryou)
        {
            this._pkout1001 = pkout1001;
            this._gwa = gwa;
            this._doctor = doctor;
            this._jubsuGubun = jubsuGubun;
            this._userId = userId;
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._orderDate = orderDate;
            this._fkout1001 = fkout1001;
            this._sinryouryouGubun = sinryouryouGubun;
            this._inputId = inputId;
            this._inputTab = inputTab;
            this._iudGubun = iudGubun;
            this._cbxSinryouryou = cbxSinryouryou;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04CreateAutoJubsuRequest();
        }
    }
}