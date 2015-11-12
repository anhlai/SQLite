using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OcsoGetNaewonYNResult : AbstractContractResult
	{
		private String _naewonYn;

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public OcsoGetNaewonYNResult() { }

	}
}