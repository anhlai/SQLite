using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
    public class CPL0108U01SaveLayoutArgs : IContractArgs
    {
        private String _userId;
        private List<CPL0108U01GrdMasterItemInfo> _grdMstItem = new List<CPL0108U01GrdMasterItemInfo>();
        private List<CPL0108U01GrdDetailInfo> _grdDetailItem = new List<CPL0108U01GrdDetailInfo>();
        private String _hospCode;

        public String UserId
        {
            get { return this._userId; }
            set { this._userId = value; }
        }

        public List<CPL0108U01GrdMasterItemInfo> GrdMstItem
        {
            get { return this._grdMstItem; }
            set { this._grdMstItem = value; }
        }

        public List<CPL0108U01GrdDetailInfo> GrdDetailItem
        {
            get { return this._grdDetailItem; }
            set { this._grdDetailItem = value; }
        }

        public String HospCode
        {
            get { return this._hospCode; }
            set { this._hospCode = value; }
        }

        public CPL0108U01SaveLayoutArgs() { }

        public CPL0108U01SaveLayoutArgs(String userId, List<CPL0108U01GrdMasterItemInfo> grdMstItem, List<CPL0108U01GrdDetailInfo> grdDetailItem, String hospCode)
        {
            this._userId = userId;
            this._grdMstItem = grdMstItem;
            this._grdDetailItem = grdDetailItem;
            this._hospCode = hospCode;
        }

        public IExtensible GetRequestInstance()
        {
            return new IHIS.CloudConnector.Messaging.CPL0108U01SaveLayoutRequest();
        }
    }
}