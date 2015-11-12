using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0801U00GrdOCS0802Args : IContractArgs
    {
        private String _patStatus;

        public String PatStatus
        {
            get { return this._patStatus; }
            set { this._patStatus = value; }
        }

        public OCS0801U00GrdOCS0802Args() { }

        public OCS0801U00GrdOCS0802Args(String patStatus)
        {
            this._patStatus = patStatus;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0801U00GrdOCS0802Request();
        }
    }
}