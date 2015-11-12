using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0110Q00LayJohapGubunArgs : IContractArgs
	{

		public BAS0110Q00LayJohapGubunArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new BAS0110Q00LayJohapGubunRequest();
		}
	}
}