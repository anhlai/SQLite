using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    [Serializable]
	public class CboSearchConditionArgs : IContractArgs
	{

		public CboSearchConditionArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new CboSearchConditionRequest();
		}
	}
}