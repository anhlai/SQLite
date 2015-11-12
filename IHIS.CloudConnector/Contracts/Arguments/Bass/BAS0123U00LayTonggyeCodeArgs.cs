using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0123U00LayTonggyeCodeArgs : IContractArgs
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

		public BAS0123U00LayTonggyeCodeArgs() { }

		public BAS0123U00LayTonggyeCodeArgs(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0123U00LayTonggyeCodeRequest();
		}
	}
}