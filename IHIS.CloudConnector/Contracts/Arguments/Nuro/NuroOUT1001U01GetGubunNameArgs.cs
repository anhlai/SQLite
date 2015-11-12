using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01GetGubunNameArgs : IContractArgs
    {
        private String _gubun;
        private String _naewonDate;
        private String _bunho;

        public String Gubun
        {
            get { return this._gubun; }
            set { this._gubun = value; }
        }

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

        public NuroOUT1001U01GetGubunNameArgs() { }

        public NuroOUT1001U01GetGubunNameArgs(String gubun, String naewonDate, String bunho)
        {
            this._gubun = gubun;
            this._naewonDate = naewonDate;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01GetGubunNameRequest();
        }
    }
}