using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OBGetBogyongInfo
	{
		private String _bogyongName;
		private String _nvl;
		private String _donbogYn;

		public String BogyongName
		{
			get { return this._bogyongName; }
			set { this._bogyongName = value; }
		}

		public String Nvl
		{
			get { return this._nvl; }
			set { this._nvl = value; }
		}

		public String DonbogYn
		{
			get { return this._donbogYn; }
			set { this._donbogYn = value; }
		}

		public OBGetBogyongInfo() { }

		public OBGetBogyongInfo(String bogyongName, String nvl, String donbogYn)
		{
			this._bogyongName = bogyongName;
			this._nvl = nvl;
			this._donbogYn = donbogYn;
		}

	}
}