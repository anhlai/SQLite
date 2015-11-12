using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR0101U01GrdDetailGridColumnChangedArgs : IContractArgs
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

		public NUR0101U01GrdDetailGridColumnChangedArgs() { }

		public NUR0101U01GrdDetailGridColumnChangedArgs(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR0101U01GrdDetailGridColumnChangedRequest();
		}
	}
}