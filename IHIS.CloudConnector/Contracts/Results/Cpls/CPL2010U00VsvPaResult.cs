using System;

namespace IHIS.CloudConnector.Contracts.Results.Cpls
{
    public class CPL2010U00VsvPaResult : AbstractContractResult
    {
        private String _suName;

        public String SuName
        {
            get { return this._suName; }
            set { this._suName = value; }
        }

        public CPL2010U00VsvPaResult() { }

    }
}