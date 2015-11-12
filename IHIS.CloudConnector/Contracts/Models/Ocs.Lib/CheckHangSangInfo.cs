using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class CheckHangSangInfo
	{
		private String _hangmogCode;
		private String _hangmogName;
		private String _sangCode;
		private String _sangName;
		private String _appDate;
		private String _inOutGubun;
		private String _gwa;
		private String _birthDate;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String HangmogName
		{
			get { return this._hangmogName; }
			set { this._hangmogName = value; }
		}

		public String SangCode
		{
			get { return this._sangCode; }
			set { this._sangCode = value; }
		}

		public String SangName
		{
			get { return this._sangName; }
			set { this._sangName = value; }
		}

		public String AppDate
		{
			get { return this._appDate; }
			set { this._appDate = value; }
		}

		public String InOutGubun
		{
			get { return this._inOutGubun; }
			set { this._inOutGubun = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String BirthDate
		{
			get { return this._birthDate; }
			set { this._birthDate = value; }
		}

		public CheckHangSangInfo() { }

		public CheckHangSangInfo(String hangmogCode, String hangmogName, String sangCode, String sangName, String appDate, String inOutGubun, String gwa, String birthDate)
		{
			this._hangmogCode = hangmogCode;
			this._hangmogName = hangmogName;
			this._sangCode = sangCode;
			this._sangName = sangName;
			this._appDate = appDate;
			this._inOutGubun = inOutGubun;
			this._gwa = gwa;
			this._birthDate = birthDate;
		}

	}
}