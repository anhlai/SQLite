using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01CheckY2Args : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;
        private String _gwa;
        private String _doctor;
        private String _naewonType;
        private String _jubsuNo;

        public NuroOUT1001U01CheckY2Args(string bunho, string naewonDate, string gwa, string doctor, string naewonType, string jubsuNo)
        {
            _bunho = bunho;
            _naewonDate = naewonDate;
            _gwa = gwa;
            _doctor = doctor;
            _naewonType = naewonType;
            _jubsuNo = jubsuNo;
        }

        public NuroOUT1001U01CheckY2Args()
        {
        }

        public string Bunho
        {
            get { return _bunho; }
            set { _bunho = value; }
        }

        public string NaewonDate
        {
            get { return _naewonDate; }
            set { _naewonDate = value; }
        }

        public string Gwa
        {
            get { return _gwa; }
            set { _gwa = value; }
        }

        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }

        public string NaewonType
        {
            get { return _naewonType; }
            set { _naewonType = value; }
        }

        public string JubsuNo
        {
            get { return _jubsuNo; }
            set { _jubsuNo = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01CheckY2Request();
        }
    }
}
