using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1101Q01FwkDoctorArgs : IContractArgs
    {
        private string _find1;
        private string _gwa;

        public NuroOUT1101Q01FwkDoctorArgs(string find1, string gwa)
        {
            _find1 = find1;
            _gwa = gwa;
        }

        public string Gwa
        {
            get { return _gwa; }
            set { _gwa = value; }
        }

        public string Find1
        {
            get { return _find1; }
            set { _find1 = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1101Q01FwkDoctorRequest();
        }
    }
}