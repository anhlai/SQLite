using System;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.NURO
{
    public class NuroOUT0101U02GetInsuranceNameArgs : IContractArgs
    {
        private String _gongbiCode;

        public String GongbiCode
        {
            get { return this._gongbiCode; }
            set { this._gongbiCode = value; }
        }

        public NuroOUT0101U02GetInsuranceNameArgs() { }

        public NuroOUT0101U02GetInsuranceNameArgs(String gongbiCode)
        {
            this._gongbiCode = gongbiCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.NuroOUT0101U02GetInsuranceNameRequest();
        }
    }
}