using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OpenAllergyInfoResult : AbstractContractResult
	{
		private String _retval;

		public String Retval
		{
			get { return this._retval; }
			set { this._retval = value; }
		}

		public OpenAllergyInfoResult() { }

	}
}