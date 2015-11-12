using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetDbMaxJubsuNoArgs : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;

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

        public NuroOUT1001U01GetDbMaxJubsuNoArgs() { }

        public NuroOUT1001U01GetDbMaxJubsuNoArgs(String bunho, String naewonDate)
        {
            this._bunho = bunho;
            this._naewonDate = naewonDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetDbMaxJubsuNoRequest();
        }
    }
}
