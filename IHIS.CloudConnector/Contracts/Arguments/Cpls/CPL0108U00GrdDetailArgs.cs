using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U00GrdDetailArgs : IContractArgs
    {
        private String _codeType;
        private String _pageNumber;
        private String _offset;

        public String CodeType
        {
            get { return this._codeType; }
            set { this._codeType = value; }
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

        public CPL0108U00GrdDetailArgs() { }

        public CPL0108U00GrdDetailArgs(String codeType, String pageNumber, String offset)
        {
            this._codeType = codeType;
            this._pageNumber = pageNumber;
            this._offset = offset;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U00GrdDetailRequest();
        }
    }
}