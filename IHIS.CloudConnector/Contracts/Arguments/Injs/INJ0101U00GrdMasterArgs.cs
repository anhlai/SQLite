using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ0101U00GrdMasterArgs : IContractArgs
	{

		public INJ0101U00GrdMasterArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new INJ0101U00GrdMasterRequest();
		}
	}
}