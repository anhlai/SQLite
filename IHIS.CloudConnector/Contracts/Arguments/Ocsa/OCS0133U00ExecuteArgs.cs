using System;
using IHIS.CloudConnector.Contracts.Models.Ocsa;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    public class OCS0133U00ExecuteArgs : IContractArgs
    {
        private List<OCS0133U00ExecuteItemInfo> _itemInfo = new List<OCS0133U00ExecuteItemInfo>();

        public List<OCS0133U00ExecuteItemInfo> ItemInfo
        {
            get { return this._itemInfo; }
            set { this._itemInfo = value; }
        }

        public OCS0133U00ExecuteArgs() { }

        public OCS0133U00ExecuteArgs(List<OCS0133U00ExecuteItemInfo> itemInfo)
        {
            this._itemInfo = itemInfo;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.OCS0133U00ExecuteRequest();
        }
    }
}