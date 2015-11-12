using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01CheckY3Args : IContractArgs
    {
        private String _bunho;
        private String _naewonDate;
        private String _jubsuNo;

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

        public String JubsuNo
        {
            get { return this._jubsuNo; }
            set { this._jubsuNo = value; }
        }

        public NuroOUT1001U01CheckY3Args() { }

        public NuroOUT1001U01CheckY3Args(String bunho, String naewonDate, String jubsuNo)
        {
            this._bunho = bunho;
            this._naewonDate = naewonDate;
            this._jubsuNo = jubsuNo;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01CheckY3Request();
        }
    }
}
