using System;
using IHIS.CloudConnector.Contracts.Models.Cpls;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Cpls
{
    public class CPL0108U01GrdMasterResult : AbstractContractResult
    {
        private List<CPL0108U01GrdMasterItemInfo> _grdMstItem = new List<CPL0108U01GrdMasterItemInfo>();

        public List<CPL0108U01GrdMasterItemInfo> GrdMstItem
        {
            get { return this._grdMstItem; }
            set { this._grdMstItem = value; }
        }

        public CPL0108U01GrdMasterResult() { }

    }
}