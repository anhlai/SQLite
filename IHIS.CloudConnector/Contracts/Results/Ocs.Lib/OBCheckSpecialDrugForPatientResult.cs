using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBCheckSpecialDrugForPatientResult : AbstractContractResult
	{
		private String _result;

		public String Result
		{
			get { return this._result; }
			set { this._result = value; }
		}

		public OBCheckSpecialDrugForPatientResult() { }

	}
}