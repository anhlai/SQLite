using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00VSVJundalGubunArgs : IContractArgs
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

		public CPL3010U00VSVJundalGubunArgs() { }

		public CPL3010U00VSVJundalGubunArgs(String code, String codeType)
		{
			this._code = code;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00VSVJundalGubunRequest();
		}
	}
}