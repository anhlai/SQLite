using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboPayArgs : IContractArgs
	{

		public ComboPayArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboPayRequest();
		}
	}
}