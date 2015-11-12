using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U09GetRootTagsForContextArgs : IContractArgs
	{

		public OCS2015U09GetRootTagsForContextArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U09GetRootTagsForContextRequest();
		}
	}
}