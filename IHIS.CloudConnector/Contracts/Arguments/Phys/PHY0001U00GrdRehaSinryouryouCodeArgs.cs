using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY0001U00GrdRehaSinryouryouCodeArgs : IContractArgs
	{

		public PHY0001U00GrdRehaSinryouryouCodeArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new PHY0001U00GrdRehaSinryouryouCodeRequest();
		}
	}
}