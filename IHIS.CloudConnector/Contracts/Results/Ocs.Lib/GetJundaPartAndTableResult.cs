using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetJundaPartAndTableResult : AbstractContractResult
	{
		private Boolean _exeResult;
		private String _jundalPartOut;
		private String _jundalPartInp;
		private String _jundalTableOut;
		private String _jundalTableInp;
		private String _movePart;
		private String _flag;
		private String _msg;

		public Boolean ExeResult
		{
			get { return this._exeResult; }
			set { this._exeResult = value; }
		}

		public String JundalPartOut
		{
			get { return this._jundalPartOut; }
			set { this._jundalPartOut = value; }
		}

		public String JundalPartInp
		{
			get { return this._jundalPartInp; }
			set { this._jundalPartInp = value; }
		}

		public String JundalTableOut
		{
			get { return this._jundalTableOut; }
			set { this._jundalTableOut = value; }
		}

		public String JundalTableInp
		{
			get { return this._jundalTableInp; }
			set { this._jundalTableInp = value; }
		}

		public String MovePart
		{
			get { return this._movePart; }
			set { this._movePart = value; }
		}

		public String Flag
		{
			get { return this._flag; }
			set { this._flag = value; }
		}

		public String Msg
		{
			get { return this._msg; }
			set { this._msg = value; }
		}

		public GetJundaPartAndTableResult() { }

	}
}