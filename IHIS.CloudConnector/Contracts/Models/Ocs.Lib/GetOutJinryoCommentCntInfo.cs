using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetOutJinryoCommentCntInfo
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;

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

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public GetOutJinryoCommentCntInfo() { }

		public GetOutJinryoCommentCntInfo(String bunho, String naewonDate, String gwa, String doctor)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
		}

	}
}