using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10GrdGeneralArgs : IContractArgs
	{
		private String _filter;
		private String _yakKijunCode;
		private String _orderDate;
		private String _hangmogCode;

		public String Filter
		{
			get { return this._filter; }
			set { this._filter = value; }
		}

		public String YakKijunCode
		{
			get { return this._yakKijunCode; }
			set { this._yakKijunCode = value; }
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

		public OCS0103U10GrdGeneralArgs() { }

		public OCS0103U10GrdGeneralArgs(String filter, String yakKijunCode, String orderDate, String hangmogCode)
		{
			this._filter = filter;
			this._yakKijunCode = yakKijunCode;
			this._orderDate = orderDate;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U10GrdGeneralRequest();
		}
	}
}