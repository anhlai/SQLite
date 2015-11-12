using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12ProtectGroupControlArgs : IContractArgs
	{
		private String _bunho;
		private String _groupSer;
		private String _orderDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String GroupSer
		{
			get { return this._groupSer; }
			set { this._groupSer = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public OCS0103U12ProtectGroupControlArgs() { }

		public OCS0103U12ProtectGroupControlArgs(String bunho, String groupSer, String orderDate)
		{
			this._bunho = bunho;
			this._groupSer = groupSer;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12ProtectGroupControlRequest();
		}
	}
}