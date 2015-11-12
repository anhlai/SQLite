using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
    public class OCS0101U00Grd0101CheckDataResult : AbstractContractResult
    {
        private String _chkResult;

        public String ChkResult
        {
            get { return this._chkResult; }
            set { this._chkResult = value; }
        }

        public OCS0101U00Grd0101CheckDataResult() { }

    }
}