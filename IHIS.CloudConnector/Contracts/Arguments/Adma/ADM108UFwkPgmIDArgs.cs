using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM108UFwkPgmIDArgs : IContractArgs
	{

		public ADM108UFwkPgmIDArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ADM108UFwkPgmIDRequest();
		}
	}
}