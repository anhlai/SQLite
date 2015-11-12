using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM201UGrdDicMasterArgs : IContractArgs
    {
        private String _colId;
        private String _colNm;
        private String _pageNumber;
        private String _offset;

        public String ColId
        {
            get { return this._colId; }
            set { this._colId = value; }
        }

        public String ColNm
        {
            get { return this._colNm; }
            set { this._colNm = value; }
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

        public ADM201UGrdDicMasterArgs() { }

        public ADM201UGrdDicMasterArgs(String colId, String colNm, String pageNumber, String offset)
        {
            this._colId = colId;
            this._colNm = colNm;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM201UGrdDicMasterRequest();
        }
    }
}