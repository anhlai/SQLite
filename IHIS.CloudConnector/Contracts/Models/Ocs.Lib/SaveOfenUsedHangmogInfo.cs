using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class SaveOfenUsedHangmogInfo
	{
		private String _iUDGubun;
		private String _membGubun;
		private String _memb;
		private String _hangmogCode;
		private String _seq;
		private String _oftenUse;
		private String _userInfo;

		public String IUDGubun
		{
			get { return this._iUDGubun; }
			set { this._iUDGubun = value; }
		}

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

		public String Seq
		{
			get { return this._seq; }
			set { this._seq = value; }
		}

		public String OftenUse
		{
			get { return this._oftenUse; }
			set { this._oftenUse = value; }
		}

		public String UserInfo
		{
			get { return this._userInfo; }
			set { this._userInfo = value; }
		}

		public SaveOfenUsedHangmogInfo() { }

		public SaveOfenUsedHangmogInfo(String iUDGubun, String membGubun, String memb, String hangmogCode, String seq, String oftenUse, String userInfo)
		{
			this._iUDGubun = iUDGubun;
			this._membGubun = membGubun;
			this._memb = memb;
			this._hangmogCode = hangmogCode;
			this._seq = seq;
			this._oftenUse = oftenUse;
			this._userInfo = userInfo;
		}

	}
}