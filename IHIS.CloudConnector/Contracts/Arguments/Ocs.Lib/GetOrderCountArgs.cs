using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetOrderCountInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetOrderCountInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetOrderCountArgs : IContractArgs
	{
		private GetOrderCountInfo _orderCountInfo;

		public GetOrderCountInfo OrderCountInfo
		{
			get { return this._orderCountInfo; }
			set { this._orderCountInfo = value; }
		}

		public GetOrderCountArgs() { }

		public GetOrderCountArgs(GetOrderCountInfo orderCountInfo)
		{
			this._orderCountInfo = orderCountInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetOrderCountRequest();
		}
	}
}