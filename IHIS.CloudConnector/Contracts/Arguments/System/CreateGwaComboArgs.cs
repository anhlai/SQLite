using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class CreateGwaComboArgs : IContractArgs
	{

		public CreateGwaComboArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new CreateGwaComboRequest();
		}
	}
}