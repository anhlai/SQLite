using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U09CheckSmoCodeOnDeleteArgs : IContractArgs
    {
        private String _clisSmoId;

        public String ClisSmoId
        {
            get { return this._clisSmoId; }
            set { this._clisSmoId = value; }
        }

        public CLIS2015U09CheckSmoCodeOnDeleteArgs() { }

        public CLIS2015U09CheckSmoCodeOnDeleteArgs(String clisSmoId)
        {
            this._clisSmoId = clisSmoId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U09CheckSmoCodeOnDeleteRequest();
        }
    }
}