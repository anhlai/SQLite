using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class BAS0001U00ExecuteArgs : IContractArgs
    {
        private List<BAS0001U00GrdBAS0001Info> _itemInfo = new List<BAS0001U00GrdBAS0001Info>();
        private String _userId;
        private String _hospCode;

        public List<BAS0001U00GrdBAS0001Info> ItemInfo
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

        public BAS0001U00ExecuteArgs() { }

        public BAS0001U00ExecuteArgs(List<BAS0001U00GrdBAS0001Info> itemInfo, String userId, String hospCode)
        {
            this._itemInfo = itemInfo;
            this._userId = userId;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.BAS0001U00ExecuteRequest();
        }
    }
}