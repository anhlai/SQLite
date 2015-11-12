using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class NoConfirmConsultInfo
	{
		private String _bunho;
		private String _naewondate;
		private String _gwa;
		private String _doctor;
		private String _ioGubun;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Naewondate
		{
			get { return this._naewondate; }
			set { this._naewondate = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public NoConfirmConsultInfo() { }

		public NoConfirmConsultInfo(String bunho, String naewondate, String gwa, String doctor, String ioGubun)
		{
			this._bunho = bunho;
			this._naewondate = naewondate;
			this._gwa = gwa;
			this._doctor = doctor;
			this._ioGubun = ioGubun;
		}

	}
}