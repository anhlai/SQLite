using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0117GrdCHT0118InitArgs : IContractArgs
    {
        private String _buwi;
        private String _queryDate;
        private String _pageNumber;
        private String _offset;

        public String Buwi
        {
            get { return this._buwi; }
            set { this._buwi = value; }
        }

        public String QueryDate
        {
            get { return this._queryDate; }
            set { this._queryDate = value; }
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

        public CHT0117GrdCHT0118InitArgs() { }

        public CHT0117GrdCHT0118InitArgs(String buwi, String queryDate, String pageNumber, String offset)
        {
            this._buwi = buwi;
            this._queryDate = queryDate;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0117GrdCHT0118InitRequest();
        }
    }
}