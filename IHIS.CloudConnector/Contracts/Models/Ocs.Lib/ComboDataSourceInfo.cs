using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class ComboDataSourceInfo
	{
		private String _colName;
		private String _arg1;
		private String _arg2;
		private String _arg3;

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

		public ComboDataSourceInfo() { }

		public ComboDataSourceInfo(String colName, String arg1, String arg2, String arg3)
		{
			this._colName = colName;
			this._arg1 = arg1;
			this._arg2 = arg2;
			this._arg3 = arg3;
		}

	}
}