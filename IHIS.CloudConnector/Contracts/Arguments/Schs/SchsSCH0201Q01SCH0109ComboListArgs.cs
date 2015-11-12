using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q01SCH0109ComboListArgs : IContractArgs
	{

		public SchsSCH0201Q01SCH0109ComboListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01SCH0109ComboListRequest();
		}
	}
}