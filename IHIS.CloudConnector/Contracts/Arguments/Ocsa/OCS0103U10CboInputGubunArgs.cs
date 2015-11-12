using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10CboInputGubunArgs : IContractArgs
	{

		public OCS0103U10CboInputGubunArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U10CboInputGubunRequest();
		}
	}
}