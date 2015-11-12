using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00SangNameArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OcsaOCS0204U00SangNameArgs() { }

		public OcsaOCS0204U00SangNameArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00SangNameRequest();
		}
	}
}