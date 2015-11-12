using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00LaySlipInfoArgs : IContractArgs
	{

		public OCS0113U00LaySlipInfoArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00LaySlipInfoRequest();
		}
	}
}