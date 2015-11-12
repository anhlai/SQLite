using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
    public class NuroInspectionOrderGetReserMoveNameResult : AbstractContractResult
    {
        private String _reserMoveName;

        public String ReserMoveName
        {
            get { return this._reserMoveName; }
            set { this._reserMoveName = value; }
        }

        public NuroInspectionOrderGetReserMoveNameResult() { }

    }
}