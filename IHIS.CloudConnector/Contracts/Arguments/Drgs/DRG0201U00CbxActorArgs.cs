using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00CbxActorArgs : IContractArgs
	{

		public DRG0201U00CbxActorArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00CbxActorRequest();
		}
	}
}