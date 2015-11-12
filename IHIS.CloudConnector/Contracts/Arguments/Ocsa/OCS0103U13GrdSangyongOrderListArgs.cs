using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U13GrdSangyongOrderListArgs : IContractArgs
    {
        private String _user;
        private String _ioGubun;
        private String _orderGubun;
        private String _orderDate;
        private String _searchWord;
        private String _wonnaeDrgYn;
        private String _pageNumber;
        private String _offset;
        private String _protocolId;

        public String User
        {
            get { return this._user; }
            set { this._user = value; }
        }

        public String IoGubun
        {
            get { return this._ioGubun; }
            set { this._ioGubun = value; }
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

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
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

        public OCS0103U13GrdSangyongOrderListArgs() { }

        public OCS0103U13GrdSangyongOrderListArgs(String user, String ioGubun, String orderGubun, String orderDate, String searchWord, String wonnaeDrgYn, String pageNumber, String offset, String protocolId)
        {
            this._user = user;
            this._ioGubun = ioGubun;
            this._orderGubun = orderGubun;
            this._orderDate = orderDate;
            this._searchWord = searchWord;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U13GrdSangyongOrderListRequest();
        }
    }
}