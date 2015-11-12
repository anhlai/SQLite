using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
	public class PFE0101U00LayUserNameArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public PFE0101U00LayUserNameArgs() { }

		public PFE0101U00LayUserNameArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new PFE0101U00LayUserNameRequest();
		}
	}
}