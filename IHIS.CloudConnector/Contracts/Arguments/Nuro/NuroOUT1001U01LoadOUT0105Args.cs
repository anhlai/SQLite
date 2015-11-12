using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class NuroOUT1001U01LoadOUT0105Args : IContractArgs
    {
        private String _gongbiCode;
        private String _fkout1001;

        public String GongbiCode
        {
            get { return this._gongbiCode; }
            set { this._gongbiCode = value; }
        }

        public String Fkout1001
        {
            get { return this._fkout1001; }
            set { this._fkout1001 = value; }
        }

        public NuroOUT1001U01LoadOUT0105Args() { }

        public NuroOUT1001U01LoadOUT0105Args(String gongbiCode, String fkout1001)
        {
            this._gongbiCode = gongbiCode;
            this._fkout1001 = fkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new NuroOUT1001U01LoadOUT0105Request();
        }
    }
}
