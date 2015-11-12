using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00GetFindWorkerArgs : IContractArgs
	{

		public OCS0113U00GetFindWorkerArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00GetFindWorkerRequest();
		}
	}
}