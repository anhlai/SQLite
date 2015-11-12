using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class OpenAllergyInfo
	{
		private String _bunho;
		private String _naewonDate;

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

		public OpenAllergyInfo() { }

		public OpenAllergyInfo(String bunho, String naewonDate)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
		}

	}
}