using System;
using IHIS.CloudConnector.Contracts.Models.Nuro;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
    public class ORDERTRANSGrdEditResult : AbstractContractResult
    {
        private List<ORDERTRANSGrdEditInfo> _grdEditItem = new List<ORDERTRANSGrdEditInfo>();

        public List<ORDERTRANSGrdEditInfo> GrdEditItem
        {
            get { return this._grdEditItem; }
            set { this._grdEditItem = value; }
        }

        public ORDERTRANSGrdEditResult() { }

    }
}