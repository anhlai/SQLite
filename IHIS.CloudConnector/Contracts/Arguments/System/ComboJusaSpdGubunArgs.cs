using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboJusaSpdGubunArgs : IContractArgs
	{

		public ComboJusaSpdGubunArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ComboJusaSpdGubunRequest();
		}
	}
}