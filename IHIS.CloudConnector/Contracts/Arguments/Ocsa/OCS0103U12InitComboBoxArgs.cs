using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    [Serializable]
	public class OCS0103U12InitComboBoxArgs : IContractArgs
	{

		public OCS0103U12InitComboBoxArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12InitComboBoxRequest();
		}
	}
}