using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT0101Q01CboSexArgs : IContractArgs
	{

		public OUT0101Q01CboSexArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OUT0101Q01CboSexRequest();
		}
	}
}