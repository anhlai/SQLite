using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00VsvHangmogCodeArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public SCH3001U00VsvHangmogCodeArgs() { }

		public SCH3001U00VsvHangmogCodeArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00VsvHangmogCodeRequest();
		}
	}
}