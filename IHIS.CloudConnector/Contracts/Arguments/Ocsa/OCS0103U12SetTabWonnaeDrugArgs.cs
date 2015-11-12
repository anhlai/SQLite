using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12SetTabWonnaeDrugArgs : IContractArgs
	{
		private String _yakKijunCode;
		private String _hangmogCode;
		private String _orderDate;

		public String YakKijunCode
		{
			get { return this._yakKijunCode; }
			set { this._yakKijunCode = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public OCS0103U12SetTabWonnaeDrugArgs() { }

		public OCS0103U12SetTabWonnaeDrugArgs(String yakKijunCode, String hangmogCode, String orderDate)
		{
			this._yakKijunCode = yakKijunCode;
			this._hangmogCode = hangmogCode;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12SetTabWonnaeDrugRequest();
		}
	}
}