using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00VsvUserNameArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public SCH3001U00VsvUserNameArgs() { }

		public SCH3001U00VsvUserNameArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00VsvUserNameRequest();
		}
	}
}