using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OBGetJundaTable1Info
	{
		private String _jundalTableOut;
		private String _jundalPartOut;
		private String _movePart;
		private String _jundalTableInp;
		private String _jundalPartInp;

		public String JundalTableOut
		{
			get { return this._jundalTableOut; }
			set { this._jundalTableOut = value; }
		}

		public String JundalPartOut
		{
			get { return this._jundalPartOut; }
			set { this._jundalPartOut = value; }
		}

		public String MovePart
		{
			get { return this._movePart; }
			set { this._movePart = value; }
		}

		public String JundalTableInp
		{
			get { return this._jundalTableInp; }
			set { this._jundalTableInp = value; }
		}

		public String JundalPartInp
		{
			get { return this._jundalPartInp; }
			set { this._jundalPartInp = value; }
		}

		public OBGetJundaTable1Info() { }

		public OBGetJundaTable1Info(String jundalTableOut, String jundalPartOut, String movePart, String jundalTableInp, String jundalPartInp)
		{
			this._jundalTableOut = jundalTableOut;
			this._jundalPartOut = jundalPartOut;
			this._movePart = movePart;
			this._jundalTableInp = jundalTableInp;
			this._jundalPartInp = jundalPartInp;
		}

	}
}