using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class IsJaewonPatientResult : AbstractContractResult
	{
		private String _yValue;

		public String YValue
		{
			get { return this._yValue; }
			set { this._yValue = value; }
		}

		public IsJaewonPatientResult() { }

	}
}