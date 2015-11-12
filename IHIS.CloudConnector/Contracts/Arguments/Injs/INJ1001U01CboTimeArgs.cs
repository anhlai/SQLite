using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01CboTimeArgs : IContractArgs
	{

		public INJ1001U01CboTimeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01CboTimeRequest();
		}
	}
}