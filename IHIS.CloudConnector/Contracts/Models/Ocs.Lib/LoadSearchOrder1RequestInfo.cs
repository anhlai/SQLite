using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
    public class LoadSearchOrder1RequestInfo
    {
        private String _searchWord;
        private String _gijunDate;
        private String _inputTab;
        private String _wonnaeDrgYn;
        private String _pageNumber;
        private String _offset;
        private String _protocolId;

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
        }

        public String GijunDate
        {
            get { return this._gijunDate; }
            set { this._gijunDate = value; }
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

        public LoadSearchOrder1RequestInfo() { }

        public LoadSearchOrder1RequestInfo(String searchWord, String gijunDate, String inputTab, String wonnaeDrgYn, String pageNumber, String offset, String protocolId)
        {
            this._searchWord = searchWord;
            this._gijunDate = gijunDate;
            this._inputTab = inputTab;
            this._wonnaeDrgYn = wonnaeDrgYn;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

    }
}