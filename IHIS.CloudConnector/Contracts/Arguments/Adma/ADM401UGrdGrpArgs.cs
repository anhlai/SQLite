using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM401UGrdGrpArgs : IContractArgs
	{

		public ADM401UGrdGrpArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new ADM401UGrdGrpRequest();
		}
	}
}