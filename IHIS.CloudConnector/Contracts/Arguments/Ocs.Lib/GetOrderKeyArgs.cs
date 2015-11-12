using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetOrderKeyArgs : IContractArgs
	{
		private String _mode;

		public String Mode
		{
			get { return this._mode; }
			set { this._mode = value; }
		}

		public GetOrderKeyArgs() { }

		public GetOrderKeyArgs(String mode)
		{
			this._mode = mode;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetOrderKeyRequest();
		}
	}
}