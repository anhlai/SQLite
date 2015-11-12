using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboPortableYnArgs : IContractArgs
	{

		public ComboPortableYnArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboPortableYnRequest();
		}
	}
}