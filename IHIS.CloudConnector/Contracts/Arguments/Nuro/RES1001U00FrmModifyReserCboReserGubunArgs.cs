using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class RES1001U00FrmModifyReserCboReserGubunArgs : IContractArgs
	{

		public RES1001U00FrmModifyReserCboReserGubunArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new RES1001U00FrmModifyReserCboReserGubunRequest();
		}
	}
}