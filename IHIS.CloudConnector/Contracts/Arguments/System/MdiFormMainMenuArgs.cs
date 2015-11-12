using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MdiFormMainMenuArgs : IContractArgs
    {
        private String _userId;
        private String _systemId;
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public MdiFormMainMenuArgs() { }

        public MdiFormMainMenuArgs(String userId, String systemId, String hospCode)
        {
            this._userId = userId;
            this._systemId = systemId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.MdiFormMainMenuRequest();
        }
    }
}