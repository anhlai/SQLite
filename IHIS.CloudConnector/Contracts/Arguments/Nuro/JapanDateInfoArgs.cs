using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public partial class JapanDateInfoArgs : IContractArgs
    {
        public JapanDateInfoArgs() { }
    
        private string _naewonDate;

        public JapanDateInfoArgs(string naewonDate)
        {
            _naewonDate = naewonDate;
        }

        public string NaewonDate
        {
            get { return _naewonDate; }
            set { _naewonDate = value; }
        }

        public IExtensible GetRequestInstance()
        {
            return new JapanDateInfoRequest();
        }
    }
}