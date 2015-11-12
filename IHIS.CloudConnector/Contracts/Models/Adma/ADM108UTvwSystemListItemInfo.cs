using System;

namespace IHIS.CloudConnector.Contracts.Models.Adma
{
	public class ADM108UTvwSystemListItemInfo
	{
		private String _pgmNm;
		private String _sysId;
		private String _sysNm;

		public String PgmNm
		{
			get { return this._pgmNm; }
			set { this._pgmNm = value; }
		}

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public String SysNm
		{
			get { return this._sysNm; }
			set { this._sysNm = value; }
		}

		public ADM108UTvwSystemListItemInfo() { }

		public ADM108UTvwSystemListItemInfo(String pgmNm, String sysId, String sysNm)
		{
			this._pgmNm = pgmNm;
			this._sysId = sysId;
			this._sysNm = sysNm;
		}

	}
}