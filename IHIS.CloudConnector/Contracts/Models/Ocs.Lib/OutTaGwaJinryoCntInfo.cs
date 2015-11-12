using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OutTaGwaJinryoCntInfo
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public OutTaGwaJinryoCntInfo() { }

		public OutTaGwaJinryoCntInfo(String bunho, String naewonDate, String gwa)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
		}

	}
}