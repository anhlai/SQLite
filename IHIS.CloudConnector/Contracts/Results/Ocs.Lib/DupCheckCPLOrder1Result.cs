using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class DupCheckCPLOrder1Result : AbstractContractResult
	{
		private String _result;

		public String Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public DupCheckCPLOrder1Result() { }

	}
}