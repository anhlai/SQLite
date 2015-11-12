using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01DeleteInTableOUT1002Args : IContractArgs
    {
        private String _pkout1001;

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public NuroOUT1001U01DeleteInTableOUT1002Args() { }

        public NuroOUT1001U01DeleteInTableOUT1002Args(String pkout1001)
        {
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01DeleteInTableOUT1002Request();
        }
    }
}