using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
	public class PFE0101U00GrdDCodeArgs : IContractArgs
	{
		private String _codeType;
		private String _code;
		private String _codeName;

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

		public String CodeName
		{
			get { return this._codeName; }
			set { this._codeName = value; }
		}

		public PFE0101U00GrdDCodeArgs() { }

		public PFE0101U00GrdDCodeArgs(String codeType, String code, String codeName)
		{
			this._codeType = codeType;
			this._code = code;
			this._codeName = codeName;
		}

		public IExtensible GetRequestInstance()
		{
			return new PFE0101U00GrdDCodeRequest();
		}
	}
}