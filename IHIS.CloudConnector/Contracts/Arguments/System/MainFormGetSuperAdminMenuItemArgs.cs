using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    public class MainFormGetSuperAdminMenuItemArgs : IContractArgs
    {
        private String _userId;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public MainFormGetSuperAdminMenuItemArgs() { }

        public MainFormGetSuperAdminMenuItemArgs(String userId)
        {
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.MainFormGetSuperAdminMenuItemRequest();
        }
    }
}