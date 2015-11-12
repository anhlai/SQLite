using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class DupCheckInputOutOrderResult : AbstractContractResult
	{
		private String _outOrder;

		public String OutOrder
		{
			get { return this._outOrder; }
			set { this._outOrder = value; }
		}

		public DupCheckInputOutOrderResult() { }

	}
}