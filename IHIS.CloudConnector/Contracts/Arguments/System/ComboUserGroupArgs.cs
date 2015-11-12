using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ComboUserGroupArgs : IContractArgs
    {
        private Boolean _getAll;
        private String _hospCode;

        public Boolean GetAll
        {
            get { return this._getAll; }
            set { this._getAll = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ComboUserGroupArgs() { }

        public ComboUserGroupArgs(Boolean getAll, String hospCode)
        {
            this._getAll = getAll;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ComboUserGroupRequest();
        }
    }
}