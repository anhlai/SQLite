using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U11LoadSlipHangmogArgs : IContractArgs
    {
        private String _searchWord;
        private String _searchCondition;
        private String _slipCode;
        private String _orderDate;
        private String _protocolId;

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
        }

        public String SearchCondition
        {
            get { return this._searchCondition; }
            set { this._searchCondition = value; }
        }

        public String SlipCode
        {
            get { return this._slipCode; }
            set { this._slipCode = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
        }

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public OCS0103U11LoadSlipHangmogArgs() { }

        public OCS0103U11LoadSlipHangmogArgs(String searchWord, String searchCondition, String slipCode, String orderDate, String protocolId)
        {
            this._searchWord = searchWord;
            this._searchCondition = searchCondition;
            this._slipCode = slipCode;
            this._orderDate = orderDate;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U11LoadSlipHangmogRequest();
        }
    }
}