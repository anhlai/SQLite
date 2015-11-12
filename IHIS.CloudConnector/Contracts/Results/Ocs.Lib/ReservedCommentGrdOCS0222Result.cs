using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    public class ReservedCommentGrdOCS0222Result : AbstractContractResult
    {
        private List<ReservedCommentGrdOCS0222Info> _grdOcs0222Item = new List<ReservedCommentGrdOCS0222Info>();

        public List<ReservedCommentGrdOCS0222Info> GrdOcs0222Item
        {
            get { return this._grdOcs0222Item; }
            set { this._grdOcs0222Item = value; }
        }

        public ReservedCommentGrdOCS0222Result() { }

    }
}