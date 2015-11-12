using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsConvertHangmogCodeResult : AbstractContractResult
	{
		private String _hangmogCode;
		private String _remark;
		private String _msgYn;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String Remark
		{
			get { return this._remark; }
			set { this._remark = value; }
		}

		public String MsgYn
		{
			get { return this._msgYn; }
			set { this._msgYn = value; }
		}

		public PrOcsConvertHangmogCodeResult() { }

	}
}