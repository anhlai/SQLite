using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00FwkBunCodeArgs : IContractArgs
    {
        private String _hospCode;
        private String _find1;
        private String _jyDate;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String JyDate
        {
            get { return this._jyDate; }
            set { this._jyDate = value; }
        }

        public BAS0203U00FwkBunCodeArgs() { }

        public BAS0203U00FwkBunCodeArgs(String hospCode, String find1, String jyDate)
        {
            this._hospCode = hospCode;
            this._find1 = find1;
            this._jyDate = jyDate;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00FwkBunCodeRequest();
        }
    }
}