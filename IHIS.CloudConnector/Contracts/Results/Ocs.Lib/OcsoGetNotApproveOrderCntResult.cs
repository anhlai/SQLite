using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OcsoGetNotApproveOrderCntResult : AbstractContractResult
	{
		private String _approveOrderCntResult;

		public String ApproveOrderCntResult
		{
			get { return this._approveOrderCntResult; }
			set { this._approveOrderCntResult = value; }
		}

		public OcsoGetNotApproveOrderCntResult() { }

	}
}