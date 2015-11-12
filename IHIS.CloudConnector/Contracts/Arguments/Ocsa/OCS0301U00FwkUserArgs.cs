using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0301U00FwkUserArgs : IContractArgs
    {
        private String _queryMode;
        private String _find1;
        private String _hospCode;

        public String QueryMode
        {
            get { return this._queryMode; }
            set { this._queryMode = value; }
        }

        public String Find1
        {
            get { return this._find1; }
            set { this._find1 = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0301U00FwkUserArgs() { }

        public OCS0301U00FwkUserArgs(String queryMode, String find1, String hospCode)
        {
            this._queryMode = queryMode;
            this._find1 = find1;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0301U00FwkUserRequest();
        }
    }
}