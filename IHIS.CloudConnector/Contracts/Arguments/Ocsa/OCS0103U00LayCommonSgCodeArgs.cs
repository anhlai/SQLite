using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00LayCommonSgCodeArgs : IContractArgs
    {
        private String _sgCode;
        private String _startDate;
        private String _hospCode;

        public String SgCode
        {
            get { return this._sgCode; }
            set { this._sgCode = value; }
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

        public OCS0103U00LayCommonSgCodeArgs() { }

        public OCS0103U00LayCommonSgCodeArgs(String sgCode, String startDate, String hospCode)
        {
            this._sgCode = sgCode;
            this._startDate = startDate;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00LayCommonSgCodeRequest();
        }
    }
}