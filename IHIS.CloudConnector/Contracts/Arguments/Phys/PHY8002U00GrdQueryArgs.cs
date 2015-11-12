using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Phys
{
	public class PHY8002U00GrdQueryArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public PHY8002U00GrdQueryArgs() { }

		public PHY8002U00GrdQueryArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new PHY8002U00GrdQueryRequest();
		}
	}
}