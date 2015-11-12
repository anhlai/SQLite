using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U10SearchConditionCboArgs : IContractArgs
	{

		public OCS0103U10SearchConditionCboArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U10SearchConditionCboRequest();
		}
	}
}