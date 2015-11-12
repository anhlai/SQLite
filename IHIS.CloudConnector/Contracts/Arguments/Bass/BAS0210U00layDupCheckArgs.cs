using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00layDupCheckArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public BAS0210U00layDupCheckArgs() { }

		public BAS0210U00layDupCheckArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00layDupCheckRequest();
		}
	}
}