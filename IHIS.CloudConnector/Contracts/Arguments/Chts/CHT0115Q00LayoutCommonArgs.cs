using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0115Q00LayoutCommonArgs : IContractArgs
	{

		public CHT0115Q00LayoutCommonArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new CHT0115Q00LayoutCommonRequest();
		}
	}
}