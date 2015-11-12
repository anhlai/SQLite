using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
    [Serializable]
	public class DRGOCSCHKGetCautionListArgs : IContractArgs
	{

		public DRGOCSCHKGetCautionListArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new DRGOCSCHKGetCautionListRequest();
		}
	}
}