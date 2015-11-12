using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetApproveFlagsArgs : IContractArgs
	{

		public GetApproveFlagsArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new GetApproveFlagsRequest();
		}
	}
}