using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadColumnCodeNameInfo
	{
		private String _colName;
		private String _arg1;
		private String _arg2;
		private String _arg3;
		private String _value;

		public String ColName
		{
			get { return this._colName; }
			set { this._colName = value; }
		}

		public String Arg1
		{
			get { return this._arg1; }
			set { this._arg1 = value; }
		}

		public String Arg2
		{
			get { return this._arg2; }
			set { this._arg2 = value; }
		}

		public String Arg3
		{
			get { return this._arg3; }
			set { this._arg3 = value; }
		}

		public String Value
		{
			get { return this._value; }
			set { this._value = value; }
		}

		public LoadColumnCodeNameInfo() { }

		public LoadColumnCodeNameInfo(String colName, String arg1, String arg2, String arg3, String value)
		{
			this._colName = colName;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
			this._value = value;
		}

	}
}