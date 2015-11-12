using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboNur0101Args : IContractArgs
	{

		public ComboNur0101Args() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboNur0101Request();
		}
	}
}