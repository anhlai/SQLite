using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class SaveRegularOrderResult : AbstractContractResult
	{
		private Boolean _result;

		public Boolean Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public SaveRegularOrderResult() { }

	}
}