using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U13PrOcsApplyNdayOrderArgs : IContractArgs
	{
		private String _bunho;
		private String _orderDate;

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

		public OCS0103U13PrOcsApplyNdayOrderArgs() { }

		public OCS0103U13PrOcsApplyNdayOrderArgs(String bunho, String orderDate)
		{
			this._bunho = bunho;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U13PrOcsApplyNdayOrderRequest();
		}
	}
}