using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10DrugTreeArgs : IContractArgs
	{

		public OCS0103U10DrugTreeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U10DrugTreeRequest();
		}
	}
}