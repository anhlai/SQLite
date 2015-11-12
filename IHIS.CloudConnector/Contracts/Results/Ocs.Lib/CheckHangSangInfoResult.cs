using System;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class CheckHangSangInfoResult : AbstractContractResult
	{
		private DataStringListItemInfo _resultCheck;

		public DataStringListItemInfo ResultCheck
		{
			get { return this._resultCheck; }
			set { this._resultCheck = value; }
		}

		public CheckHangSangInfoResult() { }

	}
}