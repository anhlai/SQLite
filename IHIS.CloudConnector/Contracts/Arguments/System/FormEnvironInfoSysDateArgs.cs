using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class FormEnvironInfoSysDateArgs : IContractArgs
	{

		public FormEnvironInfoSysDateArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new FormEnvironInfoSysDateRequest();
		}
	}
}