using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00FwkGwaArgs : IContractArgs
    {
        private String _find1;
        private String _code;
        private String _buseoYmd;
        private String _hospCode;

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        public String BuseoYmd
        {
            get { return this._buseoYmd; }
            set { this._buseoYmd = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public BAS0270U00FwkGwaArgs() { }

        public BAS0270U00FwkGwaArgs(String find1, String code, String buseoYmd, String hospCode)
        {
            this._find1 = find1;
            this._code = code;
            this._buseoYmd = buseoYmd;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00FwkGwaRequest();
        }
    }
}