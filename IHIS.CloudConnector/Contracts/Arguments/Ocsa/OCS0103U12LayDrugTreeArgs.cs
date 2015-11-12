using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12LayDrugTreeArgs : IContractArgs
	{

		public OCS0103U12LayDrugTreeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12LayDrugTreeRequest();
		}
	}
}