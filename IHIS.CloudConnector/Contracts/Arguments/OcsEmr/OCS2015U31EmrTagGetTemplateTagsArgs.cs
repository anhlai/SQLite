using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
    public class OCS2015U31EmrTagGetTemplateTagsArgs : IContractArgs
    {
        private String _strTagCode;

        public String StrTagCode
        {
            get { return this._strTagCode; }
            set { this._strTagCode = value; }
        }

        public OCS2015U31EmrTagGetTemplateTagsArgs() { }

        public OCS2015U31EmrTagGetTemplateTagsArgs(String strTagCode)
        {
            this._strTagCode = strTagCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS2015U31EmrTagGetTemplateTagsRequest();
        }
    }
}