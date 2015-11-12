using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetOrderKeyResult : AbstractContractResult
	{
		private String _orderKeyValue;

		public String OrderKeyValue
		{
			get { return this._orderKeyValue; }
			set { this._orderKeyValue = value; }
		}

		public GetOrderKeyResult() { }

	}
}