using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboNaewonYnArgs : IContractArgs
	{

		public ComboNaewonYnArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboNaewonYnRequest();
		}
	}
}