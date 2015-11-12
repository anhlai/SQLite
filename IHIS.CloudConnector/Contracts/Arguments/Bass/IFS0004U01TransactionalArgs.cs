using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
    public class IFS0004U01TransactionalArgs : IContractArgs
    {
        private List<IFS0004U01grdDetailtListItemInfo> _listDetail = new List<IFS0004U01grdDetailtListItemInfo>();
        private List<IFS0004U01grdMasterListItemInfo> _listMaster = new List<IFS0004U01grdMasterListItemInfo>();
        private String _userId;

        public List<IFS0004U01grdDetailtListItemInfo> ListDetail
        {
            get { return this._listDetail; }
            set { this._listDetail = value; }
        }

        public List<IFS0004U01grdMasterListItemInfo> ListMaster
        {
            get { return this._listMaster; }
            set { this._listMaster = value; }
        }

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public IFS0004U01TransactionalArgs() { }

        public IFS0004U01TransactionalArgs(List<IFS0004U01grdDetailtListItemInfo> listDetail, List<IFS0004U01grdMasterListItemInfo> listMaster, String userId)
        {
            this._listDetail = listDetail;
            this._listMaster = listMaster;
            this._userId = userId;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.IFS0004U01TransactionalRequest();
        }
    }
}