using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0120U00GrdNaebogArgs : IContractArgs
	{

		public DRG0120U00GrdNaebogArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new DRG0120U00GrdNaebogRequest();
		}
	}
}