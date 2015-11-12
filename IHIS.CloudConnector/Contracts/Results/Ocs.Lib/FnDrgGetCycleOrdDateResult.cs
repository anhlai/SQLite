using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class FnDrgGetCycleOrdDateResult : AbstractContractResult
	{
		private String _date;

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public FnDrgGetCycleOrdDateResult() { }

	}
}