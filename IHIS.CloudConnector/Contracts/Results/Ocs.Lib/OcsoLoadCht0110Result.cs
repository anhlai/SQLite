using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    public class OcsoLoadCht0110Result : AbstractContractResult
    {
        private List<OcsoLoadCht0110Info> _cht0110Info = new List<OcsoLoadCht0110Info>();

        public List<OcsoLoadCht0110Info> Cht0110Info
        {
            get { return this._cht0110Info; }
            set { this._cht0110Info = value; }
        }

        public OcsoLoadCht0110Result() { }

    }
}