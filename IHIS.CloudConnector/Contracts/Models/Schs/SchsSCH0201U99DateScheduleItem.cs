using System;

namespace IHIS.CloudConnector.Contracts.Models.Schs
{
	public class SchsSCH0201U99DateScheduleItemInfo
	{
		private String _dayofmon;
		private String _checkYn;
		private String _inwon;

		public String Dayofmon
		{
			get { return this._dayofmon; }
			set { this._dayofmon = value; }
		}

		public String CheckYn
		{
			get { return this._checkYn; }
			set { this._checkYn = value; }
		}

		public String Inwon
		{
			get { return this._inwon; }
			set { this._inwon = value; }
		}

		public SchsSCH0201U99DateScheduleItemInfo() { }

        public SchsSCH0201U99DateScheduleItemInfo(String dayofmon, String checkYn, String inwon)
		{
			this._dayofmon = dayofmon;
			this._checkYn = checkYn;
			this._inwon = inwon;
		}

	}
}