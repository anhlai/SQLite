using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboNalsuArgs : IContractArgs
	{

		public ComboNalsuArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboNalsuRequest();
		}
	}
}