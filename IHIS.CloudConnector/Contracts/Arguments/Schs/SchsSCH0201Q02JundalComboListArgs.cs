using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    [Serializable]
	public class SchsSCH0201Q02JundalComboListArgs : IContractArgs
	{

		public SchsSCH0201Q02JundalComboListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q02JundalComboListRequest();
		}
	}
}