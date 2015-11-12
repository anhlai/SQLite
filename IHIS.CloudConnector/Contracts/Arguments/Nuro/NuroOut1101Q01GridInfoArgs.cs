using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
public class NuroOut1101Q01GridInfoArgs : IContractArgs
    {
        private string _doctor;
        private string _gwa;
        private string _naewonDate;

        public NuroOut1101Q01GridInfoArgs()
        {
        }

        public NuroOut1101Q01GridInfoArgs(string doctor, string gwa, string naewonDate)
        {
            _doctor = doctor;
            _gwa = gwa;
            _naewonDate = naewonDate;
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

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1101Q01GridInfoRequest();
        }
    }
}