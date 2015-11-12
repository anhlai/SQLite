using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboJubsuGubunArgs : IContractArgs
	{

		public ComboJubsuGubunArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboJubsuGubunRequest();
		}
	}
}