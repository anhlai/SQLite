using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01MlayConstantInfoArgs : IContractArgs
	{

		public INJ1001U01MlayConstantInfoArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01MlayConstantInfoRequest();
		}
	}
}