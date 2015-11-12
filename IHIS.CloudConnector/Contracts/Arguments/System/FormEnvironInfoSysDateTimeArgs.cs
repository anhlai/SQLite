using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class FormEnvironInfoSysDateTimeArgs : IContractArgs
	{

		public FormEnvironInfoSysDateTimeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new FormEnvironInfoSysDateTimeRequest();
		}
	}
}