using System;
using IHIS.CloudConnector.Contracts.Models.Bass;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Bass
{
    public class ComBizLoadColumnCodeNameResult : AbstractContractResult
    {
        private String _value;

        public String Value
        {
            get { return this._value; }
            set { this._value = value; }
        }

        public ComBizLoadColumnCodeNameResult() { }

    }
}