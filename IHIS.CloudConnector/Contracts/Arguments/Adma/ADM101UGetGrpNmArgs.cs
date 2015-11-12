using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM101UGetGrpNmArgs : IContractArgs
	{

		public ADM101UGetGrpNmArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ADM101UGetGrpNmRequest();
		}
	}
}