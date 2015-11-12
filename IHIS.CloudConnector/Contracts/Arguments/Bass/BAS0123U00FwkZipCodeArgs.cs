using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0123U00FwkZipCodeArgs : IContractArgs
	{
		private String _code;
		private String _find1;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public BAS0123U00FwkZipCodeArgs() { }

		public BAS0123U00FwkZipCodeArgs(String code, String find1)
		{
			this._code = code;
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0123U00FwkZipCodeRequest();
		}
	}
}