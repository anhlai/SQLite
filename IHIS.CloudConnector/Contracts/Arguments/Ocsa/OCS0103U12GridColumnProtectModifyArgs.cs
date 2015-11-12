using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12GridColumnProtectModifyArgs : IContractArgs
	{
		private String _orderDate;
		private String _bunho;
		private String _hangmogCode;

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public OCS0103U12GridColumnProtectModifyArgs() { }

		public OCS0103U12GridColumnProtectModifyArgs(String orderDate, String bunho, String hangmogCode)
		{
			this._orderDate = orderDate;
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12GridColumnProtectModifyRequest();
		}
	}
}