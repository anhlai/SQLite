using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U31EmrTemplateArgs : IContractArgs
    {
        private String _sysId;
        private String _userGroup;

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public String UserGroup
        {
            get { return this._userGroup; }
            set { this._userGroup = value; }
        }

        public OCS2015U31EmrTemplateArgs() { }

        public OCS2015U31EmrTemplateArgs(String sysId, String userGroup)
        {
            this._sysId = sysId;
            this._userGroup = userGroup;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U31EmrTemplateRequest();
        }
    }
}