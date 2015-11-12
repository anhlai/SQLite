using System;
using IHIS.CloudConnector.Contracts.Models.Ocso;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    public class OCSACTBtnEMRClickArgs : IContractArgs
    {
        private String _naewonKey;

        public String NaewonKey
        {
            get { return this._naewonKey; }
            set { this._naewonKey = value; }
        }

        public OCSACTBtnEMRClickArgs() { }

        public OCSACTBtnEMRClickArgs(String naewonKey)
        {
            this._naewonKey = naewonKey;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCSACTBtnEMRClickRequest();
        }
    }
}