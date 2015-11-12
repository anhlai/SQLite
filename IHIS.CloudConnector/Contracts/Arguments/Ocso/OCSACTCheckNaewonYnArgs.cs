using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTCheckNaewonYnArgs : IContractArgs
    {
        private String _pkout1001;

        public String Pkout1001
        {
            get { return this._pkout1001; }
            set { this._pkout1001 = value; }
        }

        public OCSACTCheckNaewonYnArgs() { }

        public OCSACTCheckNaewonYnArgs(String pkout1001)
        {
            this._pkout1001 = pkout1001;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTCheckNaewonYnRequest();
        }
    }
}