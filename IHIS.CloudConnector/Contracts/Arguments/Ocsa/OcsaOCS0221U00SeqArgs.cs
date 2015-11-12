using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0221U00SeqArgs : IContractArgs
	{

		public OcsaOCS0221U00SeqArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0221U00SeqRequest();
		}
	}
}