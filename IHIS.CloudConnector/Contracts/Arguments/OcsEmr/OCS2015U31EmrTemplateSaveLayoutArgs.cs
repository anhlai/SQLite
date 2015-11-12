using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U31EmrTemplateSaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _userGroup;
        private List<OCS2015U31EmrTemplateSaveLayoutInfo> _saveLayoutTemplateItem = new List<OCS2015U31EmrTemplateSaveLayoutInfo>();

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

        public List<OCS2015U31EmrTemplateSaveLayoutInfo> SaveLayoutTemplateItem
        {
            get { return this._saveLayoutTemplateItem; }
            set { this._saveLayoutTemplateItem = value; }
        }

        public OCS2015U31EmrTemplateSaveLayoutArgs() { }

        public OCS2015U31EmrTemplateSaveLayoutArgs(String userId, String userGroup, List<OCS2015U31EmrTemplateSaveLayoutInfo> saveLayoutTemplateItem)
        {
            this._userId = userId;
            this._userGroup = userGroup;
            this._saveLayoutTemplateItem = saveLayoutTemplateItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U31EmrTemplateSaveLayoutRequest();
        }
    }
}