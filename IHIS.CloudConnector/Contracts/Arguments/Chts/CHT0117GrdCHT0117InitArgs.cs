using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0117GrdCHT0117InitArgs : IContractArgs
    {
        private String _queryDate;
        private String _searchWord;
        private String _pageNumber;
        private String _offset;

        public String QueryDate
        {
            get { return this._queryDate; }
            set { this._queryDate = value; }
        }

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
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

        public CHT0117GrdCHT0117InitArgs() { }

        public CHT0117GrdCHT0117InitArgs(String queryDate, String searchWord, String pageNumber, String offset)
        {
            this._queryDate = queryDate;
            this._searchWord = searchWord;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0117GrdCHT0117InitRequest();
        }
    }
}