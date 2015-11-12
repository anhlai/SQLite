using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class IpwonReserStatusInfo
	{
		private String _doctor;
		private String _bunho;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public IpwonReserStatusInfo() { }

		public IpwonReserStatusInfo(String doctor, String bunho)
		{
			this._doctor = doctor;
			this._bunho = bunho;
		}

	}
}