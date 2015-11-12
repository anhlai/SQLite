using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM101UFwkBuseoQryArgs : IContractArgs
	{

		public ADM101UFwkBuseoQryArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ADM101UFwkBuseoQryRequest();
		}
	}
}