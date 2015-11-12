using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U02GrdStatusArgs : IContractArgs
    {
        private String _protocolId;

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public CLIS2015U02GrdStatusArgs() { }

        public CLIS2015U02GrdStatusArgs(String protocolId)
        {
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U02GrdStatusRequest();
        }
    }
}