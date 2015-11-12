using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U00GetPatientInfoArgs : IContractArgs
    {
        private String _bunho;

        public String Bunho
        {
            get { return this._bunho; }
            set { this._bunho = value; }
        }

        public OCS2015U00GetPatientInfoArgs() { }

        public OCS2015U00GetPatientInfoArgs(String bunho)
        {
            this._bunho = bunho;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U00GetPatientInfoRequest();
        }
    }
}