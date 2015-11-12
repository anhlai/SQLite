using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocso
{
	public class OUTSANGU00getCodeNameResult : AbstractContractResult
	{
		private String _codeName;

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public OUTSANGU00getCodeNameResult() { }

	}
}