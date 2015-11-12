using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class IsToiwonGojiYNandEndOrderResult : AbstractContractResult
	{
		private String _toiwonGojiYn;

		public String ToiwonGojiYn
		{
			get { return this._toiwonGojiYn; }
			set { this._toiwonGojiYn = value; }
		}

		public IsToiwonGojiYNandEndOrderResult() { }

	}
}