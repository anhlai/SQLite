using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04FnOutCheckNaewonYnArgs : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _naewonType;
        private String _jubsuNo;
        private String _chojae;

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

        public String Chojae
        {
            get { return this._chojae; }
            set { this._chojae = value; }
        }

        public PHY2001U04FnOutCheckNaewonYnArgs() { }

        public PHY2001U04FnOutCheckNaewonYnArgs(String bunho, String naewonDate, String gwa, String doctor, String naewonType, String jubsuNo, String chojae)
        {
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._naewonType = naewonType;
            this._jubsuNo = jubsuNo;
            this._chojae = chojae;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04FnOutCheckNaewonYnRequest();
        }
    }
}