using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U19GrdJaeryoOrderArgs : IContractArgs
    {
        private String _searchWord;
        private String _searchCondition;
        private String _inputTab;
        private String _mode;
        private String _orderGubun;
        private String _orderDate;
        private String _wonnaeDrgYn;
        private String _pageNumber;
        private String _offset;
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

        public String OrderGubun
        {
            get { return this._orderGubun; }
            set { this._orderGubun = value; }
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

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public OCS0103U19GrdJaeryoOrderArgs() { }

        public OCS0103U19GrdJaeryoOrderArgs(String searchWord, String searchCondition, String inputTab, String mode, String orderGubun, String orderDate, String wonnaeDrgYn, String pageNumber, String offset, String protocolId)
        {
            this._searchWord = searchWord;
            this._searchCondition = searchCondition;
            this._inputTab = inputTab;
            this._mode = mode;
            this._orderGubun = orderGubun;
            this._orderDate = orderDate;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U19GrdJaeryoOrderRequest();
        }
    }
}