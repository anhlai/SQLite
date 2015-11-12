using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U06OrderTypeComboArgs : IContractArgs
	{

		public OCS2015U06OrderTypeComboArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U06OrderTypeComboRequest();
		}
	}
}