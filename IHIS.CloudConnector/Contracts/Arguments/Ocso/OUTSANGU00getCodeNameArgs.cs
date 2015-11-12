using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OUTSANGU00getCodeNameArgs : IContractArgs
	{
		private String _code;
		private String _sangEndSayU;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String SangEndSayU
		{
			get { return this._sangEndSayU; }
			set { this._sangEndSayU = value; }
		}

		public OUTSANGU00getCodeNameArgs() { }

		public OUTSANGU00getCodeNameArgs(String code, String sangEndSayU)
		{
			this._code = code;
			this._sangEndSayU = sangEndSayU;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUTSANGU00getCodeNameRequest();
		}
	}
}