using System;
using IHIS.CloudConnector.Contracts.Models.Adma;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
    public class ADM102USaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<ADM102UGrdListItemInfo> _inputList = new List<ADM102UGrdListItemInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<ADM102UGrdListItemInfo> InputList
        {
            get { return this._inputList; }
            set { this._inputList = value; }
        }

        public ADM102USaveLayoutArgs() { }

        public ADM102USaveLayoutArgs(String userId, List<ADM102UGrdListItemInfo> inputList)
        {
            this._userId = userId;
            this._inputList = inputList;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ADM102USaveLayoutRequest();
        }
    }
}