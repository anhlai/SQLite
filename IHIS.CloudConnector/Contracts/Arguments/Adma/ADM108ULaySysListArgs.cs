using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM108ULaySysListArgs : IContractArgs
	{

		public ADM108ULaySysListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ADM108ULaySysListRequest();
		}
	}
}