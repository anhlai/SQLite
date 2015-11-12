using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPLMASTERUPLOADERPRCplBmlUploaderArgs : IContractArgs
    {
        private String _userId;
        private String _hospCode;
        private List<CPLMASTERUPLOADERPRCplBmlUploaderInfo> _uplItem = new List<CPLMASTERUPLOADERPRCplBmlUploaderInfo>();

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

        public List<CPLMASTERUPLOADERPRCplBmlUploaderInfo> UplItem
        {
            get { return this._uplItem; }
            set { this._uplItem = value; }
        }

        public CPLMASTERUPLOADERPRCplBmlUploaderArgs() { }

        public CPLMASTERUPLOADERPRCplBmlUploaderArgs(String userId, String hospCode, List<CPLMASTERUPLOADERPRCplBmlUploaderInfo> uplItem)
        {
            this._userId = userId;
            this._hospCode = hospCode;
            this._uplItem = uplItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPLMASTERUPLOADERPRCplBmlUploaderRequest();
        }
    }
}