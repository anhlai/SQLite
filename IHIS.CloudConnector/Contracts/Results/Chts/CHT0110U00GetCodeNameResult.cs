using System;

namespace IHIS.CloudConnector.Contracts.Results.Chts
{
    public class CHT0110U00GetCodeNameResult : AbstractContractResult
    {
        private String _codeName;

        public String CodeName
        {
            get { return this._codeName; }
            set { this._codeName = value; }
        }

        public CHT0110U00GetCodeNameResult() { }

    }
}