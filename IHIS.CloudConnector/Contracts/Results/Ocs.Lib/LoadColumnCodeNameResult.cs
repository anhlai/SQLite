using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadColumnCodeNameResult : AbstractContractResult
	{
		private String _retVal;

		public String RetVal
		{
			get { return this._retVal; }
			set { this._retVal = value; }
		}

		public LoadColumnCodeNameResult() { }

	}
}