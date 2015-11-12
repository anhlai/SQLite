using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0123U00GrdBAS0123Args : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public BAS0123U00GrdBAS0123Args() { }

		public BAS0123U00GrdBAS0123Args(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0123U00GrdBAS0123Request();
		}
	}
}