using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1101Q01DoctorNameInfoArgs : IContractArgs
    {
        public NuroOUT1101Q01DoctorNameInfoArgs() { }
    
        private string _gwa;

        public NuroOUT1101Q01DoctorNameInfoArgs(string gwa, string doctor)
        {
            _gwa = gwa;
            _doctor = doctor;
        }

        public string Gwa
        {
            get { return _gwa; }
            set { _gwa = value; }
        }
        private string _doctor;
        public string Doctor
        {
            get { return _doctor; }
            set { _doctor = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1101Q01DoctorNameInfoRequest();
        }
    }
}