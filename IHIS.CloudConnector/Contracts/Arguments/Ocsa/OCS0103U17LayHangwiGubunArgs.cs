using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U17LayHangwiGubunArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0103U17LayHangwiGubunArgs() { }

		public OCS0103U17LayHangwiGubunArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U17LayHangwiGubunRequest();
		}
	}
}