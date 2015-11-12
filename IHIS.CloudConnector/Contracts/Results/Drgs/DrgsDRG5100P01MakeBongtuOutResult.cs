using System;

namespace IHIS.CloudConnector.Contracts.Results.Drgs
{
	public class DrgsDRG5100P01MakeBongtuOutResult : AbstractContractResult
	{
		private Boolean _result;

		public Boolean Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public DrgsDRG5100P01MakeBongtuOutResult() { }

	}
}