using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM106UMakeQueryListItemArgs : IContractArgs
    {
        private String _sysId;
        private String _upperMenu;

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public String UpperMenu
        {
            get { return this._upperMenu; }
            set { this._upperMenu = value; }
        }

        public ADM106UMakeQueryListItemArgs() { }

        public ADM106UMakeQueryListItemArgs(String sysId, String upperMenu)
        {
            this._sysId = sysId;
            this._upperMenu = upperMenu;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM106UMakeQueryListItemRequest();
        }
    }
}