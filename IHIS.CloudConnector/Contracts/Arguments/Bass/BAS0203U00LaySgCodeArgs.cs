using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0203U00LaySgCodeArgs : IContractArgs
    {
        private String _hospCode;
        private String _sgYmd;
        private String _sgCode;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String SgYmd
        {
            get { return this._sgYmd; }
            set { this._sgYmd = value; }
        }

        public String SgCode
        {
            get { return this._sgCode; }
            set { this._sgCode = value; }
        }

        public BAS0203U00LaySgCodeArgs() { }

        public BAS0203U00LaySgCodeArgs(String hospCode, String sgYmd, String sgCode)
        {
            this._hospCode = hospCode;
            this._sgYmd = sgYmd;
            this._sgCode = sgCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0203U00LaySgCodeRequest();
        }
    }
}