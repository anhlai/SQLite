using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NUR2001U04CboGwaArgs : IContractArgs
	{

		public NUR2001U04CboGwaArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new NUR2001U04CboGwaRequest();
		}
	}
}