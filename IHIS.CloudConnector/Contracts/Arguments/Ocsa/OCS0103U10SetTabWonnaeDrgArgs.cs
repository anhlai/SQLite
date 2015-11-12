using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10SetTabWonnaeDrgArgs : IContractArgs
	{
		private String _yakKijunCode;
		private String _orderDate;
		private String _inputTab;
		private String _hangmogCode;

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

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public OCS0103U10SetTabWonnaeDrgArgs() { }

		public OCS0103U10SetTabWonnaeDrgArgs(String yakKijunCode, String orderDate, String inputTab, String hangmogCode)
		{
			this._yakKijunCode = yakKijunCode;
			this._orderDate = orderDate;
			this._inputTab = inputTab;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U10SetTabWonnaeDrgRequest();
		}
	}
}