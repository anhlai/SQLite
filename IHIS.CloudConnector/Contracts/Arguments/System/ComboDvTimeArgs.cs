using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboDvTimeArgs : IContractArgs
	{

		public ComboDvTimeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboDvTimeRequest();
		}
	}
}