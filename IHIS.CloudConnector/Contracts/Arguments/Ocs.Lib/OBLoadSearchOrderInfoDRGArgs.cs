using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class OBLoadSearchOrderInfoDRGArgs : IContractArgs
    {
        private String _searchWord;
        private String _searchCondition;
        private String _genericSearchYn;
        private String _gijunDate;
        private String _wonnaeDrgYn;
        private String _inputTab;
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

        public String GenericSearchYn
        {
            get { return this._genericSearchYn; }
            set { this._genericSearchYn = value; }
        }

        public String GijunDate
        {
            get { return this._gijunDate; }
            set { this._gijunDate = value; }
        }

        public String WonnaeDrgYn
        {
            get { return this._wonnaeDrgYn; }
            set { this._wonnaeDrgYn = value; }
        }

        public String InputTab
        {
            get { return this._inputTab; }
            set { this._inputTab = value; }
        }

        public String ProtocolId
        {
            get { return this._protocolId; }
            set { this._protocolId = value; }
        }

        public OBLoadSearchOrderInfoDRGArgs() { }

        public OBLoadSearchOrderInfoDRGArgs(String searchWord, String searchCondition, String genericSearchYn, String gijunDate, String wonnaeDrgYn, String inputTab, String protocolId)
        {
            this._searchWord = searchWord;
            this._searchCondition = searchCondition;
            this._genericSearchYn = genericSearchYn;
            this._gijunDate = gijunDate;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._inputTab = inputTab;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OBLoadSearchOrderInfoDRGRequest();
        }
    }
}