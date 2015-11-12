using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ0101U00GrdDetailGridColumnChangedArgs : IContractArgs
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

		public INJ0101U00GrdDetailGridColumnChangedArgs() { }

		public INJ0101U00GrdDetailGridColumnChangedArgs(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ0101U00GrdDetailGridColumnChangedRequest();
		}
	}
}