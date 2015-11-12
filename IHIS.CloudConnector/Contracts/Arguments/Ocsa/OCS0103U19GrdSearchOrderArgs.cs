using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U19GrdSearchOrderArgs : IContractArgs
    {
        private String _searchWord;
        private String _searchCondition;
        private String _inputTab;
        private String _mode;
        private String _slipCode;
        private String _orderDate;
        private String _wonnaeDrgYn;
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

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public String Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
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

        public String WonnaeDrgYn
        {
            get { return this._wonnaeDrgYn; }
            set { this._wonnaeDrgYn = value; }
        }

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public OCS0103U19GrdSearchOrderArgs() { }

        public OCS0103U19GrdSearchOrderArgs(String searchWord, String searchCondition, String inputTab, String mode, String slipCode, String orderDate, String wonnaeDrgYn, String protocolId)
        {
            this._searchWord = searchWord;
            this._searchCondition = searchCondition;
            this._inputTab = inputTab;
            this._mode = mode;
            this._slipCode = slipCode;
            this._orderDate = orderDate;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U19GrdSearchOrderRequest();
        }
    }
}