using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class HOTCODEMASTERGetGrdListArgs : IContractArgs
    {
        private String _hotCode;
        private String _hangmogName;
        private String _offset;
        private String _pageNumber;

        public String HotCode
        {
            get { return this._hotCode; }
            set { this._hotCode = value; }
        }

        public String HangmogName
        {
            get { return this._hangmogName; }
            set { this._hangmogName = value; }
        }

        public String Offset
        {
            get { return this._offset; }
            set { this._offset = value; }
        }

        public String PageNumber
        {
            get { return this._pageNumber; }
            set { this._pageNumber = value; }
        }

        public HOTCODEMASTERGetGrdListArgs() { }

        public HOTCODEMASTERGetGrdListArgs(String hotCode, String hangmogName, String offset, String pageNumber)
        {
            this._hotCode = hotCode;
            this._hangmogName = hangmogName;
            this._offset = offset;
            this._pageNumber = pageNumber;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.HOTCODEMASTERGetGrdListRequest();
        }
    }
}