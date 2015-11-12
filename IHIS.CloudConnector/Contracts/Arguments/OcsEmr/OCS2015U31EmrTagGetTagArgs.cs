using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U31EmrTagGetTagArgs : IContractArgs
    {
        private String _sysId;
        private String _tagCode;

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public String TagCode
        {
            get { return this._tagCode; }
            set { this._tagCode = value; }
        }

        public OCS2015U31EmrTagGetTagArgs() { }

        public OCS2015U31EmrTagGetTagArgs(String sysId, String tagCode)
        {
            this._sysId = sysId;
            this._tagCode = tagCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U31EmrTagGetTagRequest();
        }
    }
}