using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class NoConfirmConsultResult : AbstractContractResult
	{
		private String _retval;

		public String Retval
		{
			get { return this._retval; }
			set { this._retval = value; }
		}

		public NoConfirmConsultResult() { }

	}
}