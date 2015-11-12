using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
    [Serializable]
	public class SCH0201Q12ComboListArgs : IContractArgs
	{

		public SCH0201Q12ComboListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new SCH0201Q12ComboListRequest();
		}
	}
}