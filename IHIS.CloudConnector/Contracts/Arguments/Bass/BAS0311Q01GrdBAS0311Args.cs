using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0311Q01GrdBAS0311Args : IContractArgs
    {
        private String _searchWord;
        private String _nuGroup;
        private String _pageNumber;
        private String _offset;

        public String SearchWord
        {
            get { return this._searchWord; }
            set { this._searchWord = value; }
        }

        public String NuGroup
        {
            get { return this._nuGroup; }
            set { this._nuGroup = value; }
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

        public BAS0311Q01GrdBAS0311Args() { }

        public BAS0311Q01GrdBAS0311Args(String searchWord, String nuGroup, String pageNumber, String offset)
        {
            this._searchWord = searchWord;
            this._nuGroup = nuGroup;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0311Q01GrdBAS0311Request();
        }
    }
}