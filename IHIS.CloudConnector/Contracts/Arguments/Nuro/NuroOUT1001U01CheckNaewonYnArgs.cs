using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01CheckNaewonYnArgs : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _naewonType;
        private String _oldJubsuNo;
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

        public String OldJubsuNo
        {
            get { return this._oldJubsuNo; }
            set { this._oldJubsuNo = value; }
        }

        public String Chojae
        {
            get { return this._chojae; }
            set { this._chojae = value; }
        }

        public NuroOUT1001U01CheckNaewonYnArgs() { }

        public NuroOUT1001U01CheckNaewonYnArgs(String bunho, String naewonDate, String gwa, String doctor, String naewonType, String oldJubsuNo, String chojae)
        {
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._doctor = doctor;
            this._naewonType = naewonType;
            this._oldJubsuNo = oldJubsuNo;
            this._chojae = chojae;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01CheckNaewonYnRequest();
        }
    }
}
