using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM104UGridUserSaveLayoutArgs : IContractArgs
    {
        private List<ADM104UGridUserInfo> _itemInfo = new List<ADM104UGridUserInfo>();
        private String _userId;
        private String _hospCode;

        public List<ADM104UGridUserInfo> ItemInfo
        {
            get { return this._itemInfo; }
            set { this._itemInfo = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM104UGridUserSaveLayoutArgs() { }

        public ADM104UGridUserSaveLayoutArgs(List<ADM104UGridUserInfo> itemInfo, String userId, String hospCode)
        {
            this._itemInfo = itemInfo;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM104UGridUserSaveLayoutRequest();
        }
    }
}