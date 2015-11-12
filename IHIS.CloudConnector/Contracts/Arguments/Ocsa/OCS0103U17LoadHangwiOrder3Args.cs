using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U17LoadHangwiOrder3Args : IContractArgs
    {
        private String _searchword;
        private String _searchcondition;
        private String _mode;
        private String _slipCode;
        private String _codeYn;
        private String _inputTab;
        private String _wonnaeDrgYn;
        private String _user;
        private String _orderDate;
        private String _pageNumber;
        private String _offset;
        private String _protocolId;

        public String Searchword
        {
            get { return this._searchword; }
            set { this._searchword = value; }
        }

        public String Searchcondition
        {
            get { return this._searchcondition; }
            set { this._searchcondition = value; }
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

        public String CodeYn
        {
            get { return this._codeYn; }
            set { this._codeYn = value; }
        }

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public String WonnaeDrgYn
        {
            get { return this._wonnaeDrgYn; }
            set { this._wonnaeDrgYn = value; }
        }

        public String User
        {
            get { return this._user; }
            set { this._user = value; }
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

        public OCS0103U17LoadHangwiOrder3Args() { }

        public OCS0103U17LoadHangwiOrder3Args(String searchword, String searchcondition, String mode, String slipCode, String codeYn, String inputTab, String wonnaeDrgYn, String user, String orderDate, String pageNumber, String offset, String protocolId)
        {
            this._searchword = searchword;
            this._searchcondition = searchcondition;
            this._mode = mode;
            this._slipCode = slipCode;
            this._codeYn = codeYn;
            this._inputTab = inputTab;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._user = user;
            this._orderDate = orderDate;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U17LoadHangwiOrder3Request();
        }
    }
}