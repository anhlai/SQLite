using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class ExistAllergyDataResult : AbstractContractResult
	{
		private String _cntValue;

		public String CntValue
		{
			get { return this._cntValue; }
			set { this._cntValue = value; }
		}

		public ExistAllergyDataResult() { }

	}
}