using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U00EmrGetNoticeEditTimeArgs : IContractArgs
	{

		public OCS2015U00EmrGetNoticeEditTimeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U00EmrGetNoticeEditTimeRequest();
		}
	}
}