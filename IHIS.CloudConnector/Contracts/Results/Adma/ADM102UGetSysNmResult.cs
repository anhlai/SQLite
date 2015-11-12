using System;

namespace IHIS.CloudConnector.Contracts.Results.Adma
{
    public class ADM102UGetSysNmResult : AbstractContractResult
    {
        private String _sysNm;

        public String SysNm
        {
            get { return this._sysNm; }
            set { this._sysNm = value; }
        }

        public ADM102UGetSysNmResult() { }

    }
}