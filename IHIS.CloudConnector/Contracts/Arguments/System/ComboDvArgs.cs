using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboDvArgs : IContractArgs
	{

		public ComboDvArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboDvRequest();
		}
	}
}