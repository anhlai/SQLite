using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class DeleteOftenUsedHangmogInfo
	{
		private String _membGubun;
		private String _memb;
		private String _hangmogCode;

		public String MembGubun
		{
			get { return this._membGubun; }
			set { this._membGubun = value; }
		}

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public DeleteOftenUsedHangmogInfo() { }

		public DeleteOftenUsedHangmogInfo(String membGubun, String memb, String hangmogCode)
		{
			this._membGubun = membGubun;
			this._memb = memb;
			this._hangmogCode = hangmogCode;
		}

	}
}