using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class InsteadModifiedCheckResult : AbstractContractResult
	{
		private String _isPossibleInsteadOrder;

		public String IsPossibleInsteadOrder
		{
			get { return this._isPossibleInsteadOrder; }
			set { this._isPossibleInsteadOrder = value; }
		}

		public InsteadModifiedCheckResult() { }

	}
}