using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboSuryangArgs : IContractArgs
	{

		public ComboSuryangArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboSuryangRequest();
		}
	}
}