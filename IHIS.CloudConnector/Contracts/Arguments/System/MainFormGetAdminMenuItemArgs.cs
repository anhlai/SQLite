using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MainFormGetAdminMenuItemArgs : IContractArgs
    {
        private String _hospCode;
        private String _userId;

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

        public MainFormGetAdminMenuItemArgs() { }

        public MainFormGetAdminMenuItemArgs(String hospCode, String userId)
        {
            this._hospCode = hospCode;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.MainFormGetAdminMenuItemRequest();
        }
    }
}