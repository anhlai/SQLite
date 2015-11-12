using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Orca
{
    public class ShunouArgs : IContractArgs
    {
        private string _patientId;
        private string _performDate = "";
        private string _performMonth = "";
        private string _performYear = "";

        public ShunouArgs()
        {
            
        }
        public ShunouArgs(string patientId, string performDate, string performMonth, string performYear)
        {
            _patientId = patientId;
            _performDate = performDate;
            _performMonth = performMonth;
            _performYear = performYear;
        }

        public string PatientId
        {
            get { return _patientId; }
            set { _patientId = value; }
        }

        public string PerformDate
        {
            get { return _performDate; }
            set { _performDate = value; }
        }

        public string PerformMonth
        {
            get { return _performMonth; }
            set { _performMonth = value; }
        }

        public string PerformYear
        {
            get { return _performYear; }
            set { _performYear = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new ShunouRequest();
        }
    }
}