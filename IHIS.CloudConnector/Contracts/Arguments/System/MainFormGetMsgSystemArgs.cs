using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MainFormGetMsgSystemArgs : IContractArgs
    {
        private String _hospCode;
        private String _userId;
        private String _groupId;

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String GroupId
        {
            get { return this._groupId; }
            set { this._groupId = value; }
        }

        public MainFormGetMsgSystemArgs() { }

        public MainFormGetMsgSystemArgs(String hospCode, String userId, String groupId)
        {
            this._hospCode = hospCode;
            this._userId = userId;
            this._groupId = groupId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.MainFormGetMsgSystemRequest();
        }
    }
}