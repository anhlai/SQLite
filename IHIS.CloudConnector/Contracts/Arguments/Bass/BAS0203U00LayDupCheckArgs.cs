using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00LayDupCheckArgs : IContractArgs
    {
        private String _hospCode;
        private String _symyaGubun;
        private String _bunCode;
        private String _sgCode;
        private String _jyDate;
        private String _fromTime;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String SymyaGubun
        {
            get { return this._symyaGubun; }
            set { this._symyaGubun = value; }
        }

        public String BunCode
        {
            get { return this._bunCode; }
            set { this._bunCode = value; }
        }

        public String SgCode
        {
            get { return this._sgCode; }
            set { this._sgCode = value; }
        }

        public String JyDate
        {
            get { return this._jyDate; }
            set { this._jyDate = value; }
        }

        public String FromTime
        {
            get { return this._fromTime; }
            set { this._fromTime = value; }
        }

        public BAS0203U00LayDupCheckArgs() { }

        public BAS0203U00LayDupCheckArgs(String hospCode, String symyaGubun, String bunCode, String sgCode, String jyDate, String fromTime)
        {
            this._hospCode = hospCode;
            this._symyaGubun = symyaGubun;
            this._bunCode = bunCode;
            this._sgCode = sgCode;
            this._jyDate = jyDate;
            this._fromTime = fromTime;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00LayDupCheckRequest();
        }
    }
}