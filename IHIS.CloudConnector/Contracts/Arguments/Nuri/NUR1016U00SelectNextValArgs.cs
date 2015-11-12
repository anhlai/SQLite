using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1016U00SelectNextValArgs : IContractArgs
	{

		public NUR1016U00SelectNextValArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new NUR1016U00SelectNextValRequest();
		}
	}
}