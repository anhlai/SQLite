using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0110U00TransactionalArgs : IContractArgs
    {
        private List<BAS0110U00GrdJohapListItemInfo> _listInfo = new List<BAS0110U00GrdJohapListItemInfo>();
        private String _userId;

        public List<BAS0110U00GrdJohapListItemInfo> ListInfo
        {
            get { return this._listInfo; }
            set { this._listInfo = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public BAS0110U00TransactionalArgs() { }

        public BAS0110U00TransactionalArgs(List<BAS0110U00GrdJohapListItemInfo> listInfo, String userId)
        {
            this._listInfo = listInfo;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0110U00TransactionalRequest();
        }
    }
}