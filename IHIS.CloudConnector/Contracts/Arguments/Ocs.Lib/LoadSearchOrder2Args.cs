using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
    public class LoadSearchOrder2Args : IContractArgs
    {
        private LoadSearchOrder2RequestInfo _inputInfo;
        private String _pageNumber;
        private String _offset;
        private String _protocolId;

        public LoadSearchOrder2RequestInfo InputInfo
        {
            get { return this._inputInfo; }
            set { this._inputInfo = value; }
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

        public LoadSearchOrder2Args() { }

        public LoadSearchOrder2Args(LoadSearchOrder2RequestInfo inputInfo, String pageNumber, String offset, String protocolId)
        {
            this._inputInfo = inputInfo;
            this._pageNumber = pageNumber;
            this._offset = offset;
            this._protocolId = protocolId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.LoadSearchOrder2Request();
        }
    }
}