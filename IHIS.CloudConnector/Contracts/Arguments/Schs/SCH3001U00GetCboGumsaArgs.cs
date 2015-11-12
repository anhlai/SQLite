using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00GetCboGumsaArgs : IContractArgs
	{

		public SCH3001U00GetCboGumsaArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00GetCboGumsaRequest();
		}
	}
}