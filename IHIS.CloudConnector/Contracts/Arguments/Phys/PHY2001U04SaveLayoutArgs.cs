using System;
using IHIS.CloudConnector.Contracts.Models.Phys;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
    public class PHY2001U04SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<PHY2001U04SaveLayoutInfo> _saveLayoutItem = new List<PHY2001U04SaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<PHY2001U04SaveLayoutInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public PHY2001U04SaveLayoutArgs() { }

        public PHY2001U04SaveLayoutArgs(String userId, List<PHY2001U04SaveLayoutInfo> saveLayoutItem)
        {
            this._userId = userId;
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.PHY2001U04SaveLayoutRequest();
        }
    }
}