using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0212U00LaydupCheckArgs : IContractArgs
    {
        private String _code;
        private String _startDate;

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String StartDate
        {
            get { return this._startDate; }
            set { this._startDate = value; }
        }

        public BAS0212U00LaydupCheckArgs() { }

        public BAS0212U00LaydupCheckArgs(String code, String startDate)
        {
            this._code = code;
            this._startDate = startDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0212U00LaydupCheckRequest();
        }
    }
}