using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY8002U00InsertInitValueArgs : IContractArgs
	{

		public PHY8002U00InsertInitValueArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new PHY8002U00InsertInitValueRequest();
		}
	}
}