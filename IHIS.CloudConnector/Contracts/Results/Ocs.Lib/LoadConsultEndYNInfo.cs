using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class LoadConsultEndYNInfo
	{
		private String _bunho;
		private String _reqDoctor;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String ReqDoctor
		{
			get { return this._reqDoctor; }
			set { this._reqDoctor = value; }
		}

		public LoadConsultEndYNInfo() { }

		public LoadConsultEndYNInfo(String bunho, String reqDoctor)
		{
			this._bunho = bunho;
			this._reqDoctor = reqDoctor;
		}

	}
}