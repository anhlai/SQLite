using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U15LaySlipCodeTreeArgs : IContractArgs
	{

		public OCS0103U15LaySlipCodeTreeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U15LaySlipCodeTreeRequest();
		}
	}
}