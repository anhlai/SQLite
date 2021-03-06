using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetUserOptionInfo
	{
		private String _doctor;
		private String _gwa;
		private String _keyword;
		private String _ioGubun;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Keyword
		{
			get { return this._keyword; }
			set { this._keyword = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public GetUserOptionInfo() { }

		public GetUserOptionInfo(String doctor, String gwa, String keyword, String ioGubun)
		{
			this._doctor = doctor;
			this._gwa = gwa;
			this._keyword = keyword;
			this._ioGubun = ioGubun;
		}

	}
}