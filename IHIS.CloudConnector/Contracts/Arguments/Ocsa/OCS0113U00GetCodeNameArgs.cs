using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00GetCodeNameArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OCS0113U00GetCodeNameArgs() { }

		public OCS0113U00GetCodeNameArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00GetCodeNameRequest();
		}
	}
}