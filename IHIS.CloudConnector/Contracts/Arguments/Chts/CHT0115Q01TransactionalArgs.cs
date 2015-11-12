using System;
using IHIS.CloudConnector.Contracts.Models.Chts;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
    public class CHT0115Q01TransactionalArgs : IContractArgs
    {
        private List<CHT0115Q01grdCHT0115Info> _listInfo = new List<CHT0115Q01grdCHT0115Info>();
        private String _userId;

        public List<CHT0115Q01grdCHT0115Info> ListInfo
        {
            get { return this._listInfo; }
            set { this._listInfo = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public CHT0115Q01TransactionalArgs() { }

        public CHT0115Q01TransactionalArgs(List<CHT0115Q01grdCHT0115Info> listInfo, String userId)
        {
            this._listInfo = listInfo;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CHT0115Q01TransactionalRequest();
        }
    }
}