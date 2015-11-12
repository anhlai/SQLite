using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetDoctorArgs : IContractArgs
    {
        private String _naewonDate;
        private String _gwa;
        private String _find1;

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

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public NuroOUT1001U01GetDoctorArgs() { }

        public NuroOUT1001U01GetDoctorArgs(String naewonDate, String gwa, String find1)
        {
            this._naewonDate = naewonDate;
            this._gwa = gwa;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetDoctorRequest();
        }
    }
}