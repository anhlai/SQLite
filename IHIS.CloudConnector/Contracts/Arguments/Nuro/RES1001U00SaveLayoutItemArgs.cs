using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class RES1001U00SaveLayoutItemArgs : IContractArgs
    {
        private String _userId;
        private List<RES1001U00SaveLayoutItemInfo> _layoutItem = new List<RES1001U00SaveLayoutItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<RES1001U00SaveLayoutItemInfo> LayoutItem
        {
            get { return this._layoutItem; }
            set { this._layoutItem = value; }
        }

        public RES1001U00SaveLayoutItemArgs() { }

        public RES1001U00SaveLayoutItemArgs(String userId, List<RES1001U00SaveLayoutItemInfo> layoutItem)
        {
            this._userId = userId;
            this._layoutItem = layoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.RES1001U00SaveLayoutItemRequest();
        }
    }
}