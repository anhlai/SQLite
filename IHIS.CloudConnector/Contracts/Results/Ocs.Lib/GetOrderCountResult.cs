using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetOrderCountResult : AbstractContractResult
	{
		private String _orderCout;

		public String OrderCout
		{
			get { return this._orderCout; }
			set { this._orderCout = value; }
		}

		public GetOrderCountResult() { }

	}
}