using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0117LayNextSubBuwiCdArgs : IContractArgs
	{

		public CHT0117LayNextSubBuwiCdArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new CHT0117LayNextSubBuwiCdRequest();
		}
	}
}