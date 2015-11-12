using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM103SaveLayoutArgs : IContractArgs
    {
        private String _sysId;
        private List<ADM103UgrdUserGrpInfo> _itemInfo = new List<ADM103UgrdUserGrpInfo>();
        private String _hospCode;

        public String SysId
        {
            get { return this._sysId; }
            set { this._sysId = value; }
        }

        public List<ADM103UgrdUserGrpInfo> ItemInfo
        {
            get { return this._itemInfo; }
            set { this._itemInfo = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public ADM103SaveLayoutArgs() { }

        public ADM103SaveLayoutArgs(String sysId, List<ADM103UgrdUserGrpInfo> itemInfo, String hospCode)
        {
            this._sysId = sysId;
            this._itemInfo = itemInfo;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM103SaveLayoutRequest();
        }
    }
}