using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboGumsaArgs : IContractArgs
	{

		public ComboGumsaArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboGumsaRequest();
		}
	}
}