using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U04GetPatientListItemArgs : IContractArgs
    {
        private String _clisProtocolId;

        public String ClisProtocolId
        {
            get { return this._clisProtocolId; }
            set { this._clisProtocolId = value; }
        }

        public CLIS2015U04GetPatientListItemArgs() { }

        public CLIS2015U04GetPatientListItemArgs(String clisProtocolId)
        {
            this._clisProtocolId = clisProtocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U04GetPatientListItemRequest();
        }
    }
}