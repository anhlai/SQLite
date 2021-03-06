using System;

namespace IHIS.CloudConnector.Contracts.Models.Schs
{
	public class SCH0201Q12GrdListItemInfo
	{
		private String _kizyunDate;
		private String _gwa;
		private String _gwaName;
		private String _doctor;
		private String _doctorName;
		private String _hangmogCode;
		private String _hangmogName;
		private String _jundalTable;
		private String _jundalPart;
		private String _jundalPartName;
		private String _reserTime;
		private String _reserYn;
		private String _actYn;
		private String _orderDate;
		private String _pksch;

		public String KizyunDate
		{
			get { return this._kizyunDate; }
			set { this._kizyunDate = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String GwaName
		{
			get { return this._gwaName; }
			set { this._gwaName = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String DoctorName
		{
			get { return this._doctorName; }
			set { this._doctorName = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String HangmogName
		{
			get { return this._hangmogName; }
			set { this._hangmogName = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public String JundalPartName
		{
			get { return this._jundalPartName; }
			set { this._jundalPartName = value; }
		}

		public String ReserTime
		{
			get { return this._reserTime; }
			set { this._reserTime = value; }
		}

		public String ReserYn
		{
			get { return this._reserYn; }
			set { this._reserYn = value; }
		}

		public String ActYn
		{
			get { return this._actYn; }
			set { this._actYn = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String Pksch
		{
			get { return this._pksch; }
			set { this._pksch = value; }
		}

		public SCH0201Q12GrdListItemInfo() { }

		public SCH0201Q12GrdListItemInfo(String kizyunDate, String gwa, String gwaName, String doctor, String doctorName, String hangmogCode, String hangmogName, String jundalTable, String jundalPart, String jundalPartName, String reserTime, String reserYn, String actYn, String orderDate, String pksch)
		{
			this._kizyunDate = kizyunDate;
			this._gwa = gwa;
			this._gwaName = gwaName;
			this._doctor = doctor;
			this._doctorName = doctorName;
			this._hangmogCode = hangmogCode;
			this._hangmogName = hangmogName;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._jundalPartName = jundalPartName;
			this._reserTime = reserTime;
			this._reserYn = reserYn;
			this._actYn = actYn;
			this._orderDate = orderDate;
			this._pksch = pksch;
		}

	}
}