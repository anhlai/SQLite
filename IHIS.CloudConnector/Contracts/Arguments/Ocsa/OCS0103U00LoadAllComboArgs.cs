using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0103U00LoadAllComboArgs : IContractArgs
    {
        private Boolean _isAll;
        private String _hospCode;

        public Boolean IsAll
        {
            get { return this._isAll; }
            set { this._isAll = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public OCS0103U00LoadAllComboArgs() { }

        public OCS0103U00LoadAllComboArgs(Boolean isAll, String hospCode)
        {
            this._isAll = isAll;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0103U00LoadAllComboRequest();
        }
    }
}