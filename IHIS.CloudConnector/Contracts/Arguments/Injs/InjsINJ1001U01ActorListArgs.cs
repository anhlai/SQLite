using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01ActorListArgs : IContractArgs
	{

		public InjsINJ1001U01ActorListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01ActorListRequest();
		}
	}
}