using System;

namespace IHIS.CloudConnector.Contracts.Results.Bass
{
	public class BAS0210U00fbxDataValidatingResult : AbstractContractResult
	{
		private String _codeName;

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public BAS0210U00fbxDataValidatingResult() { }

	}
}