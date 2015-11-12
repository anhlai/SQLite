using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class HIGetHangmogNameResult : AbstractContractResult
	{
		private String _result;

		public String Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public HIGetHangmogNameResult() { }

	}
}