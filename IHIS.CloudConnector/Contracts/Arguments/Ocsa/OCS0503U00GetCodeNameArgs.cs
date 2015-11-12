using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00GetCodeNameArgs : IContractArgs
	{
		private String _codeMode;
		private String _code;

		public String CodeMode
		{
			get { return this._codeMode; }
			set { this._codeMode = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OCS0503U00GetCodeNameArgs() { }

		public OCS0503U00GetCodeNameArgs(String codeMode, String code)
		{
			this._codeMode = codeMode;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00GetCodeNameRequest();
		}
	}
}