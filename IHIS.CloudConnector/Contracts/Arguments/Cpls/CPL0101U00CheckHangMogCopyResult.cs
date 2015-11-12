using System;

namespace IHIS.CloudConnector.Contracts.Results.Cpls
{
	public class CPL0101U00CheckHangMogCopyResult : AbstractContractResult
	{
		private Boolean _result;

		public Boolean Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public CPL0101U00CheckHangMogCopyResult() { }

	}
}