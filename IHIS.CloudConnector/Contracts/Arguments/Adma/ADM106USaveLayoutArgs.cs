using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM106USaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private String _userTrm;
        private List<ADM106UMakeQueryListItemInfo> _inputList = new List<ADM106UMakeQueryListItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public String UserTrm
        {
            get { return this._userTrm; }
            set { this._userTrm = value; }
        }

        public List<ADM106UMakeQueryListItemInfo> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public ADM106USaveLayoutArgs() { }

        public ADM106USaveLayoutArgs(String userId, String userTrm, List<ADM106UMakeQueryListItemInfo> inputList)
        {
            this._userId = userId;
            this._userTrm = userTrm;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM106USaveLayoutRequest();
        }
    }
}