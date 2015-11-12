using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0310U00GrdListArgs : IContractArgs
    {
        private String _bunCode;
        private String _aText;
        private String _pageNumber;
        private String _offset;

        public String BunCode
        {
            get { return this._bunCode; }
            set { this._bunCode = value; }
        }

        public String AText
        {
            get { return this._aText; }
            set { this._aText = value; }
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

        public BAS0310U00GrdListArgs() { }

        public BAS0310U00GrdListArgs(String bunCode, String aText, String pageNumber, String offset)
        {
            this._bunCode = bunCode;
            this._aText = aText;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0310U00GrdListRequest();
        }
    }
}