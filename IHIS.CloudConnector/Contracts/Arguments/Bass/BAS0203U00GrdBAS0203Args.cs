using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00GrdBAS0203Args : IContractArgs
    {
        private String _hospCode;
        private String _jyDate;
        private String _symyaGubun;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String JyDate
        {
            get { return this._jyDate; }
            set { this._jyDate = value; }
        }

        public String SymyaGubun
        {
            get { return this._symyaGubun; }
            set { this._symyaGubun = value; }
        }

        public BAS0203U00GrdBAS0203Args() { }

        public BAS0203U00GrdBAS0203Args(String hospCode, String jyDate, String symyaGubun)
        {
            this._hospCode = hospCode;
            this._jyDate = jyDate;
            this._symyaGubun = symyaGubun;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00GrdBAS0203Request();
        }
    }
}