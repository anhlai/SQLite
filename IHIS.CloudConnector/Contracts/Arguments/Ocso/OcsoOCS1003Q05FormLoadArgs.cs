using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
    [Serializable]
	public class OcsoOCS1003Q05FormLoadArgs : IContractArgs
	{

		public OcsoOCS1003Q05FormLoadArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003Q05FormLoadRequest();
		}
	}
}