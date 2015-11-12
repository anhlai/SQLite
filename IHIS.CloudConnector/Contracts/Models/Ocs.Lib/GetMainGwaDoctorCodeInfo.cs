using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetMainGwaDoctorCodeInfo
	{
		private String _memb;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public GetMainGwaDoctorCodeInfo() { }

		public GetMainGwaDoctorCodeInfo(String memb)
		{
			this._memb = memb;
		}

	}
}