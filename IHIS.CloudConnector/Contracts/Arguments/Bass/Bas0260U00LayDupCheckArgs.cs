using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class Bas0260U00LayDupCheckArgs : IContractArgs
    {
        private String _code;
        private String _startDate;
        private String _hospCode;

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

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public Bas0260U00LayDupCheckArgs() { }

        public Bas0260U00LayDupCheckArgs(String code, String startDate, String hospCode)
        {
            this._code = code;
            this._startDate = startDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.Bas0260U00LayDupCheckRequest();
        }
    }
}