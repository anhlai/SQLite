using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class DupCheckInputOutOrderInfo
	{
		private String _bunho;
		private String _naewonDate;
		private String _gwa;
		private String _doctor;
		private String _naewonType;
		private String _jubsuNo;
		private String _hangmogCode;
		private String _hopeDate;

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

		public String NaewonType
		{
			get { return this._naewonType; }
			set { this._naewonType = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String HopeDate
		{
			get { return this._hopeDate; }
			set { this._hopeDate = value; }
		}

		public DupCheckInputOutOrderInfo() { }

		public DupCheckInputOutOrderInfo(String bunho, String naewonDate, String gwa, String doctor, String naewonType, String jubsuNo, String hangmogCode, String hopeDate)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._doctor = doctor;
			this._naewonType = naewonType;
			this._jubsuNo = jubsuNo;
			this._hangmogCode = hangmogCode;
			this._hopeDate = hopeDate;
		}

	}
}