using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0208U00LoadBogyongNameFromDrgArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OcsaOCS0208U00LoadBogyongNameFromDrgArgs() { }

		public OcsaOCS0208U00LoadBogyongNameFromDrgArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0208U00LoadBogyongNameFromDrgRequest();
		}
	}
}