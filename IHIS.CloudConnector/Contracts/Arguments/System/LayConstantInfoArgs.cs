using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class LayConstantInfoArgs : IContractArgs
	{

		public LayConstantInfoArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new LayConstantInfoRequest();
		}
	}
}