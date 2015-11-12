using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q04GetCboListArgs : IContractArgs
	{

		public SchsSCH0201Q04GetCboListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q04GetCboListRequest();
		}
	}
}