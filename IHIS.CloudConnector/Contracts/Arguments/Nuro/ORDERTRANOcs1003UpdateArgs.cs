using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
    public class ORDERTRANOcs1003UpdateArgs : IContractArgs
    {
        private List<ORDERTRANOcs1003UpdateInfo> _saveLayoutItem = new List<ORDERTRANOcs1003UpdateInfo>();

        public List<ORDERTRANOcs1003UpdateInfo> SaveLayoutItem
        {
            get { return this._saveLayoutItem; }
            set { this._saveLayoutItem = value; }
        }

        public ORDERTRANOcs1003UpdateArgs() { }

        public ORDERTRANOcs1003UpdateArgs(List<ORDERTRANOcs1003UpdateInfo> saveLayoutItem)
        {
            this._saveLayoutItem = saveLayoutItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.ORDERTRANOcs1003UpdateRequest();
        }
    }
}