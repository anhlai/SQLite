using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    public class CFFormUnevenPrescribeLayDRG0120Result : AbstractContractResult
    {
        private List<CFFormUnevenPrescribeLayDRG0120Info> _layDrgItem = new List<CFFormUnevenPrescribeLayDRG0120Info>();

        public List<CFFormUnevenPrescribeLayDRG0120Info> LayDrgItem
        {
            get { return this._layDrgItem; }
            set { this._layDrgItem = value; }
        }

        public CFFormUnevenPrescribeLayDRG0120Result() { }

    }
}