using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
    [Serializable]
	public class INJ1002U01LoadComboBoxArgs : IContractArgs
	{

		public INJ1002U01LoadComboBoxArgs() { }

		public IExtensible GetRequestInstance()
		{
			return new INJ1002U01LoadComboBoxRequest();
		}
	}
}