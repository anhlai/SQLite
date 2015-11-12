using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuri
{
	public class NUR1017U00LayValidationDupchkResult : AbstractContractResult
	{
		private String _yValue;

		public String YValue
		{
			get { return this._yValue; }
			set { this._yValue = value; }
		}

		public NUR1017U00LayValidationDupchkResult() { }

	}
}