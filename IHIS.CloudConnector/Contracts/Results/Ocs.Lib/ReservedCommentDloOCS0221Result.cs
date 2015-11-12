using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    public class ReservedCommentDloOCS0221Result : AbstractContractResult
    {
        private List<ReservedCommentDloOCS0221Info> _reservedCmtItem = new List<ReservedCommentDloOCS0221Info>();

        public List<ReservedCommentDloOCS0221Info> ReservedCmtItem
        {
            get { return this._reservedCmtItem; }
            set { this._reservedCmtItem = value; }
        }

        public ReservedCommentDloOCS0221Result() { }

    }
}