using System;
using IHIS.CloudConnector.Contracts.Models.Clis;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Clis
{
    public class CLIS2015U02GrdTrialDrgArgs : IContractArgs
    {
        private String _protocolId;
        private String _pageNumber;
        private String _offset;

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public String PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        public String Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        public CLIS2015U02GrdTrialDrgArgs() { }

        public CLIS2015U02GrdTrialDrgArgs(String protocolId, String pageNumber, String offset)
        {
            this._protocolId = protocolId;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CLIS2015U02GrdTrialDrgRequest();
        }
    }
}