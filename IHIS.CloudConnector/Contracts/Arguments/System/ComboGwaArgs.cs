using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class ComboGwaArgs : IContractArgs
	{

		public IExtensible GetRequestInstance()
		{
			return new ComboGwaRequest();
		}
	}
}