using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetOrderCountInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetOrderCountInfo;
using GetUserOptionInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetUserOptionInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01GetUserOptionAndOrderCountArgs : IContractArgs
	{
		private GetUserOptionInfo _userOption;
		private GetOrderCountInfo _orderCount;

		public GetUserOptionInfo UserOption
		{
			get { return this._userOption; }
			set { this._userOption = value; }
		}

		public GetOrderCountInfo OrderCount
		{
			get { return this._orderCount; }
			set { this._orderCount = value; }
		}

		public OCS1003P01GetUserOptionAndOrderCountArgs() { }

		public OCS1003P01GetUserOptionAndOrderCountArgs(GetUserOptionInfo userOption, GetOrderCountInfo orderCount)
		{
			this._userOption = userOption;
			this._orderCount = orderCount;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01GetUserOptionAndOrderCountRequest();
		}
	}
}