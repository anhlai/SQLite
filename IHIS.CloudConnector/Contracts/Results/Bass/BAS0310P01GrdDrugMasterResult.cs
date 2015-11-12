using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Bass
{
    public class BAS0310P01GrdDrugMasterResult : AbstractContractResult
    {
        private List<BAS0310P01GrdDrugMasterInfo> _dt = new List<BAS0310P01GrdDrugMasterInfo>();

        public List<BAS0310P01GrdDrugMasterInfo> Dt
        {
            get { return this._dt; }
            set { this._dt = value; }
        }

        public BAS0310P01GrdDrugMasterResult() { }

    }
}