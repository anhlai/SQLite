using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class LoadOcs0132Args : IContractArgs
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

		public LoadOcs0132Args() { }

		public LoadOcs0132Args(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new LoadOcs0132Request();
		}
	}
}