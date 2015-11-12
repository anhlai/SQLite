using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00GrdOCS0205ListArgs : IContractArgs
	{
		private String _fMemb;
		private String _sangGubun;

		public String FMemb
		{
			get { return this._fMemb; }
			set { this._fMemb = value; }
		}

		public String SangGubun
		{
			get { return this._sangGubun; }
			set { this._sangGubun = value; }
		}

		public OcsaOCS0204U00GrdOCS0205ListArgs() { }

		public OcsaOCS0204U00GrdOCS0205ListArgs(String fMemb, String sangGubun)
		{
			this._fMemb = fMemb;
			this._sangGubun = sangGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00GrdOCS0205ListRequest();
		}
	}
}