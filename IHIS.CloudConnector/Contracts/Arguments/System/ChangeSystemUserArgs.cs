using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class ChangeSystemUserArgs : IContractArgs
    {
        private String _afUserId;
        private String _bfUserId;
        private String _systemId;
        private String _ipAddr;

        public String AfUserId
        {
            get { return this._afUserId; }
            set { this._afUserId = value; }
        }

        public String BfUserId
        {
            get { return this._bfUserId; }
            set { this._bfUserId = value; }
        }

        public String SystemId
        {
            get { return this._systemId; }
            set { this._systemId = value; }
        }

        public String IpAddr
        {
            get { return this._ipAddr; }
            set { this._ipAddr = value; }
        }

        public ChangeSystemUserArgs() { }

        public ChangeSystemUserArgs(String afUserId, String bfUserId, String systemId, String ipAddr)
        {
            this._afUserId = afUserId;
            this._bfUserId = bfUserId;
            this._systemId = systemId;
            this._ipAddr = ipAddr;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ChangeSystemUserRequest();
        }
    }
}