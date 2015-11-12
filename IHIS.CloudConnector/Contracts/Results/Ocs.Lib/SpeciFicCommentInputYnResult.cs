using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class SpeciFicCommentInputYnResult : AbstractContractResult
	{
		private Boolean _checkTableRow;
		private String _yValue;

		public Boolean CheckTableRow
		{
			get { return this._checkTableRow; }
			set { this._checkTableRow = value; }
		}

		public String YValue
		{
			get { return this._yValue; }
			set { this._yValue = value; }
		}

		public SpeciFicCommentInputYnResult() { }

	}
}