using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboSangEndSayuArgs : IContractArgs
	{

		public ComboSangEndSayuArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboSangEndSayuRequest();
		}
	}
}