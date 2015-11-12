using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0270U00LayGwaArgs : IContractArgs
    {
        private String _gwa;
        private String _buseoYmd;
        private String _hospCode;

        public String Gwa
        {
            get { return this._gwa; }
            set { this._gwa = value; }
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

        public BAS0270U00LayGwaArgs() { }

        public BAS0270U00LayGwaArgs(String gwa, String buseoYmd, String hospCode)
        {
            this._gwa = gwa;
            this._buseoYmd = buseoYmd;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0270U00LayGwaRequest();
        }
    }
}