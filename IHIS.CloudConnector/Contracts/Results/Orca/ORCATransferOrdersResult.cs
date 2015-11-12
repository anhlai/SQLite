using System;
using IHIS.CloudConnector.Contracts.Models.Orca;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Orca
{
    public class ORCATransferOrdersResult : AbstractContractResult
    {
        private List<ORCATransferOrdersHeaderInfo> _headerItem = new List<ORCATransferOrdersHeaderInfo>();
        private List<ORCATransferOrdersHealthInsuranceInfo> _healthInsItem = new List<ORCATransferOrdersHealthInsuranceInfo>();
        private List<ORCATransferOrdersDiseaseInfo> _diseaseItem = new List<ORCATransferOrdersDiseaseInfo>();
        private List<ORCATransferOrdersClaimInfo> _claimItem = new List<ORCATransferOrdersClaimInfo>();

        public List<ORCATransferOrdersHeaderInfo> HeaderItem
        {
            get { return this._headerItem; }
            set { this._headerItem = value; }
        }

        public List<ORCATransferOrdersHealthInsuranceInfo> HealthInsItem
        {
            get { return this._healthInsItem; }
            set { this._healthInsItem = value; }
        }

        public List<ORCATransferOrdersDiseaseInfo> DiseaseItem
        {
            get { return this._diseaseItem; }
            set { this._diseaseItem = value; }
        }

        public List<ORCATransferOrdersClaimInfo> ClaimItem
        {
            get { return this._claimItem; }
            set { this._claimItem = value; }
        }

        public ORCATransferOrdersResult() { }

    }
}