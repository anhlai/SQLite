using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00SangGubunNameArgs : IContractArgs
	{
		private String _memb;
		private String _code;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OcsaOCS0204U00SangGubunNameArgs() { }

		public OcsaOCS0204U00SangGubunNameArgs(String memb, String code)
		{
			this._memb = memb;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00SangGubunNameRequest();
		}
	}
}