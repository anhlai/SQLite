using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetTypeArgs : IContractArgs
    {
        private String _naewonDate;
        private String _bunho;
        private String _find1;

        public String NaewonDate
        {
            get { return this._naewonDate; }
            set { this._naewonDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public NuroOUT1001U01GetTypeArgs() { }

        public NuroOUT1001U01GetTypeArgs(String naewonDate, String bunho, String find1)
        {
            this._naewonDate = naewonDate;
            this._bunho = bunho;
            this._find1 = find1;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetTypeRequest();
        }
    }
}