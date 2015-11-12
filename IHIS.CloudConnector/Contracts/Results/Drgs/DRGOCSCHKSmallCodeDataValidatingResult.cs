using System;

namespace IHIS.CloudConnector.Contracts.Results.Drgs
{
	public class DRGOCSCHKSmallCodeDataValidatingResult : AbstractContractResult
	{
		private String _codeName1;

		public String CodeName1
		{
			get { return this._codeName1; }
			set { this._codeName1 = value; }
		}

		public DRGOCSCHKSmallCodeDataValidatingResult() { }

	}
}