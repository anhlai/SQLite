using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadColumnCodeNameInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadColumnCodeNameInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadColumnCodeNameArgs : IContractArgs
	{
		private LoadColumnCodeNameInfo _requestValue;

		public LoadColumnCodeNameInfo RequestValue
		{
			get { return this._requestValue; }
			set { this._requestValue = value; }
		}

		public LoadColumnCodeNameArgs() { }

		public LoadColumnCodeNameArgs(LoadColumnCodeNameInfo requestValue)
		{
			this._requestValue = requestValue;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadColumnCodeNameRequest();
		}
	}
}