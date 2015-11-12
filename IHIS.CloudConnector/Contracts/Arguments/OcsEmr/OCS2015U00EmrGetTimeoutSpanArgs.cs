using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U00EmrGetTimeoutSpanArgs : IContractArgs
	{

		public OCS2015U00EmrGetTimeoutSpanArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U00EmrGetTimeoutSpanRequest();
		}
	}
}