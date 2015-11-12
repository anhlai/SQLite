using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0117Q00DloCHT0117Args : IContractArgs
	{

		public CHT0117Q00DloCHT0117Args() { }

		public IExtensible GetRequestInstance()
		{
			return new CHT0117Q00DloCHT0117Request();
		}
	}
}