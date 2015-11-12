using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANPRMakeIFS1004Args : IContractArgs
    {
        private List<ORDERTRANPRMakeIFS1004Info> _inputInfo = new List<ORDERTRANPRMakeIFS1004Info>();

        public List<ORDERTRANPRMakeIFS1004Info> InputInfo
        {
            get { return this._inputInfo; }
            set { this._inputInfo = value; }
        }

        public ORDERTRANPRMakeIFS1004Args() { }

        public ORDERTRANPRMakeIFS1004Args(List<ORDERTRANPRMakeIFS1004Info> inputInfo)
        {
            this._inputInfo = inputInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANPRMakeIFS1004Request();
        }
    }
}