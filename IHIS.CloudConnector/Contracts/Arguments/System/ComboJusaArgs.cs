using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboJusaArgs : IContractArgs
	{

		public ComboJusaArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboJusaRequest();
		}
	}
}