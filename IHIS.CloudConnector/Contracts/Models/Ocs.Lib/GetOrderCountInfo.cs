using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetOrderCountInfo
	{
		private String _ioGubun;
		private String _bunho;
		private String _orderDate;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public GetOrderCountInfo() { }

		public GetOrderCountInfo(String ioGubun, String bunho, String orderDate)
		{
			this._ioGubun = ioGubun;
			this._bunho = bunho;
			this._orderDate = orderDate;
		}

	}
}