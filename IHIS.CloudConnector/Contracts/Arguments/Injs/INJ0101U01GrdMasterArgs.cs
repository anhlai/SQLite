using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ0101U01GrdMasterArgs : IContractArgs
	{

		public INJ0101U01GrdMasterArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new INJ0101U01GrdMasterRequest();
		}
	}
}