using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS0301U00SeqResult : AbstractContractResult
	{
		private String _seq;

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public OCS0301U00SeqResult() { }

	}
}