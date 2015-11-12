using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0108U00ExecuteArgs : IContractArgs
    {
        private List<OCS0108U00grdOCS0108ItemInfo> _itemInfo = new List<OCS0108U00grdOCS0108ItemInfo>();
        private String _userId;
        private String _hospCode;

        public List<OCS0108U00grdOCS0108ItemInfo> ItemInfo
        {
            get { return this._itemInfo; }
            set { this._itemInfo = value; }
        }

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

        public OCS0108U00ExecuteArgs() { }

        public OCS0108U00ExecuteArgs(List<OCS0108U00grdOCS0108ItemInfo> itemInfo, String userId, String hospCode)
        {
            this._itemInfo = itemInfo;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0108U00ExecuteRequest();
        }
    }
}