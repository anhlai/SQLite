using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH0109U00LayDupDArgs : IContractArgs
	{
		private String _code;
		private String _codeType;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public SCH0109U00LayDupDArgs() { }

		public SCH0109U00LayDupDArgs(String code, String codeType)
		{
			this._code = code;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH0109U00LayDupDRequest();
		}
	}
}