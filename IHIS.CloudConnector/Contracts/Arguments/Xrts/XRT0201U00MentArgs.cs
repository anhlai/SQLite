using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00MentArgs : IContractArgs
	{

		public XRT0201U00MentArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00MentRequest();
		}
	}
}