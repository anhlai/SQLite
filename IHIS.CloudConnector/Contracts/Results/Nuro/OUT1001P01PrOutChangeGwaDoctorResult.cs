using System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
	public class OUT1001P01PrOutChangeGwaDoctorResult : AbstractContractResult
	{
		private String _error;

		public String Error
		{
			get { return this._error; }
			set { this._error = value; }
		}

		public OUT1001P01PrOutChangeGwaDoctorResult() { }

	}
}