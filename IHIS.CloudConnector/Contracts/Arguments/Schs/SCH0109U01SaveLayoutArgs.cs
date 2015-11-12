using System;
using IHIS.CloudConnector.Contracts.Models.Schs;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    public class SCH0109U01SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<SCH0109U01GrdMasterInfo> _grdMstItem = new List<SCH0109U01GrdMasterInfo>();
        private List<SCH0109U01GrdDetailInfo> _grdDetailItem = new List<SCH0109U01GrdDetailInfo>();

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<SCH0109U01GrdMasterInfo> GrdMstItem
        {
            get { return this._grdMstItem; }
            set { this._grdMstItem = value; }
        }

        public List<SCH0109U01GrdDetailInfo> GrdDetailItem
        {
            get { return this._grdDetailItem; }
            set { this._grdDetailItem = value; }
        }

        public SCH0109U01SaveLayoutArgs() { }

        public SCH0109U01SaveLayoutArgs(String userId, List<SCH0109U01GrdMasterInfo> grdMstItem, List<SCH0109U01GrdDetailInfo> grdDetailItem)
        {
            this._userId = userId;
            this._grdMstItem = grdMstItem;
            this._grdDetailItem = grdDetailItem;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.SCH0109U01SaveLayoutRequest();
        }
    }
}