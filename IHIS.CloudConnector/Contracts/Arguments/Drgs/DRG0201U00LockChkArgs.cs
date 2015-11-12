using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0201U00LockChkArgs : IContractArgs
	{

		public DRG0201U00LockChkArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new DRG0201U00LockChkRequest();
		}
	}
}