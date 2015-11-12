using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0106U00SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<CPL0106U00GrdListItemInfo> _inputList = new List<CPL0106U00GrdListItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<CPL0106U00GrdListItemInfo> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public CPL0106U00SaveLayoutArgs() { }

        public CPL0106U00SaveLayoutArgs(String userId, List<CPL0106U00GrdListItemInfo> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0106U00SaveLayoutRequest();
        }
    }
}