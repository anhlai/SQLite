using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U14LaySlipCodeTreeArgs : IContractArgs
	{
		private String _user;

		public String User
		{
			get { return this._user; }
			set { this._user = value; }
		}

		public OCS0103U14LaySlipCodeTreeArgs() { }

		public OCS0103U14LaySlipCodeTreeArgs(String user)
		{
			this._user = user;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U14LaySlipCodeTreeRequest();
		}
	}
}