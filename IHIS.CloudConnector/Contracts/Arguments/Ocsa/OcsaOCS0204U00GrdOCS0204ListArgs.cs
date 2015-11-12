using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00GrdOCS0204ListArgs : IContractArgs
	{
		private String _fMemb;

		public String FMemb
		{
			get { return this._fMemb; }
			set { this._fMemb = value; }
		}

		public OcsaOCS0204U00GrdOCS0204ListArgs() { }

		public OcsaOCS0204U00GrdOCS0204ListArgs(String fMemb)
		{
			this._fMemb = fMemb;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00GrdOCS0204ListRequest();
		}
	}
}