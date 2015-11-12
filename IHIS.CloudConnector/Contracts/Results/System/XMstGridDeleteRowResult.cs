using System;

namespace IHIS.CloudConnector.Contracts.Results.System
{
    public class XMstGridDeleteRowResult : AbstractContractResult
    {
        private String _result;

        public String Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        public XMstGridDeleteRowResult() { }

    }
}