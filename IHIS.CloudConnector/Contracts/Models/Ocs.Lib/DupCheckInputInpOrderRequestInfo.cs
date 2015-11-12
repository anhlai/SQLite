using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class DupCheckInputInpOrderRequestInfo
	{
		private String _bunho;
		private String _fkinp1001;
		private String _orderDate;
		private String _hangmogCode;
		private String _hopeDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Fkinp1001
		{
			get { return this._fkinp1001; }
			set { this._fkinp1001 = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
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

		public DupCheckInputInpOrderRequestInfo() { }

		public DupCheckInputInpOrderRequestInfo(String bunho, String fkinp1001, String orderDate, String hangmogCode, String hopeDate)
		{
			this._bunho = bunho;
			this._fkinp1001 = fkinp1001;
			this._orderDate = orderDate;
			this._hangmogCode = hangmogCode;
			this._hopeDate = hopeDate;
		}

	}
}