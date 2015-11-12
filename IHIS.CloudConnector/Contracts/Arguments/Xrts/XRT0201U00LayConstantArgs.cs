using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00LayConstantArgs : IContractArgs
	{

		public XRT0201U00LayConstantArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00LayConstantRequest();
		}
	}
}