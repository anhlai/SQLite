using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U04GetPatientStatusListItemArgs : IContractArgs
    {
        private String _protocolPatientId;

        public String ProtocolPatientId
        {
            get { return this._protocolPatientId; }
            set { this._protocolPatientId = value; }
        }

        public CLIS2015U04GetPatientStatusListItemArgs() { }

        public CLIS2015U04GetPatientStatusListItemArgs(String protocolPatientId)
        {
            this._protocolPatientId = protocolPatientId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U04GetPatientStatusListItemRequest();
        }
    }
}