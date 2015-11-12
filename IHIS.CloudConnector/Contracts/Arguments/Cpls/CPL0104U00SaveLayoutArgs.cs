using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0104U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<CPL0104U00GrdDetailListItemInfo> _inputList = new List<CPL0104U00GrdDetailListItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<CPL0104U00GrdDetailListItemInfo> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public CPL0104U00SaveLayoutArgs() { }

        public CPL0104U00SaveLayoutArgs(String userId, List<CPL0104U00GrdDetailListItemInfo> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0104U00SaveLayoutRequest();
        }
    }
}