using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetFindWorkerRequestInfo
	{
		private String _colname;
		private String _argu1;
		private String _argu2;
		private String _argu3;

		public String Colname
		{
			get { return this._colname; }
			set { this._colname = value; }
		}

		public String Argu1
		{
			get { return this._argu1; }
			set { this._argu1 = value; }
		}

		public String Argu2
		{
			get { return this._argu2; }
			set { this._argu2 = value; }
		}

		public String Argu3
		{
			get { return this._argu3; }
			set { this._argu3 = value; }
		}

		public GetFindWorkerRequestInfo() { }

		public GetFindWorkerRequestInfo(String colname, String argu1, String argu2, String argu3)
		{
			this._colname = colname;
			this._argu1 = argu1;
			this._argu2 = argu2;
			this._argu3 = argu3;
		}

	}
}