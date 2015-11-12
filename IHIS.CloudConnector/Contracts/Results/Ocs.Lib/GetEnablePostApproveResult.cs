using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetEnablePostApproveResult : AbstractContractResult
	{
		private String _posTapproveYn;

		public String PosTapproveYn
		{
			get { return this._posTapproveYn; }
			set { this._posTapproveYn = value; }
		}

		public GetEnablePostApproveResult() { }

	}
}