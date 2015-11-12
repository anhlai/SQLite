using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00BtnUrineClickArgs : IContractArgs
	{

		public CPL3010U00BtnUrineClickArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00BtnUrineClickRequest();
		}
	}
}