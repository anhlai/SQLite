using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503Q00FdwCommonGwaArgs : IContractArgs
	{

		public OCS0503Q00FdwCommonGwaArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0503Q00FdwCommonGwaRequest();
		}
	}
}