using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class PrOcsLoadIpwonReserInfo
	{
		private String _ipwonGwa;
		private String _parentGwa;
		private String _resident;
		private String _flag;

		public String IpwonGwa
		{
			get { return this._ipwonGwa; }
			set { this._ipwonGwa = value; }
		}

		public String ParentGwa
		{
			get { return this._parentGwa; }
			set { this._parentGwa = value; }
		}

		public String Resident
		{
			get { return this._resident; }
			set { this._resident = value; }
		}

		public String Flag
		{
			get { return this._flag; }
			set { this._flag = value; }
		}

		public PrOcsLoadIpwonReserInfo() { }

		public PrOcsLoadIpwonReserInfo(String ipwonGwa, String parentGwa, String resident, String flag)
		{
			this._ipwonGwa = ipwonGwa;
			this._parentGwa = parentGwa;
			this._resident = resident;
			this._flag = flag;
		}

	}
}