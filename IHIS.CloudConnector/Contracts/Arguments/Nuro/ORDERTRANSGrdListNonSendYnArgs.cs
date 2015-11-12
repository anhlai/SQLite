using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANSGrdListNonSendYnArgs : IContractArgs
    {
        private String _hospCode;
        private String _actingDate;
        private String _bunho;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String ActingDate
        {
            get { return this._actingDate; }
            set { this._actingDate = value; }
        }

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public ORDERTRANSGrdListNonSendYnArgs() { }

        public ORDERTRANSGrdListNonSendYnArgs(String hospCode, String actingDate, String bunho)
        {
            this._hospCode = hospCode;
            this._actingDate = actingDate;
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANSGrdListNonSendYnRequest();
        }
    }
}