using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U13GrdSearchOrderListArgs : IContractArgs
    {
        private String _searchWord;
        private String _orderDate;
        private String _pageNumber;
        private String _offset;
        private String _protocolId;

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
        }

        public String OrderDate
        {
            get { return this._orderDate; }
            set { this._orderDate = value; }
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

        public OCS0103U13GrdSearchOrderListArgs() { }

        public OCS0103U13GrdSearchOrderListArgs(String searchWord, String orderDate, String pageNumber, String offset, String protocolId)
        {
            this._searchWord = searchWord;
            this._orderDate = orderDate;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U13GrdSearchOrderListRequest();
        }
    }
}