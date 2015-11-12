using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00UserNameArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public NuroRES1001U00UserNameArgs() { }

		public NuroRES1001U00UserNameArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00UserNameRequest();
		}
	}
}