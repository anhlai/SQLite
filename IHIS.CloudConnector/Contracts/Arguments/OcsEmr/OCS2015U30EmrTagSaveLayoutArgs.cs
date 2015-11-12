using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U30EmrTagSaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _userGroup;
        private List<OCS2015U30EmrTagSaveLayoutInfo> _saveLayoutRootItem = new List<OCS2015U30EmrTagSaveLayoutInfo>();
        private List<OCS2015U30EmrTagSaveLayoutInfo> _saveLayoutNodeItem = new List<OCS2015U30EmrTagSaveLayoutInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        public List<OCS2015U30EmrTagSaveLayoutInfo> SaveLayoutRootItem
        {
            get { return this._saveLayoutRootItem; }
            set { this._saveLayoutRootItem = value; }
        }

        public List<OCS2015U30EmrTagSaveLayoutInfo> SaveLayoutNodeItem
        {
            get { return this._saveLayoutNodeItem; }
            set { this._saveLayoutNodeItem = value; }
        }

        public OCS2015U30EmrTagSaveLayoutArgs() { }

        public OCS2015U30EmrTagSaveLayoutArgs(String userId, String userGroup, List<OCS2015U30EmrTagSaveLayoutInfo> saveLayoutRootItem, List<OCS2015U30EmrTagSaveLayoutInfo> saveLayoutNodeItem)
        {
            this._userId = userId;
            this._userGroup = userGroup;
            this._saveLayoutRootItem = saveLayoutRootItem;
            this._saveLayoutNodeItem = saveLayoutNodeItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U30EmrTagSaveLayoutRequest();
        }
    }
}