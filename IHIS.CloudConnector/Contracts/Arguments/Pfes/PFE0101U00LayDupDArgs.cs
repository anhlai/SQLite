using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
	public class PFE0101U00LayDupDArgs : IContractArgs
	{
		private String _codeType;
		private String _code;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public PFE0101U00LayDupDArgs() { }

		public PFE0101U00LayDupDArgs(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new PFE0101U00LayDupDRequest();
		}
	}
}