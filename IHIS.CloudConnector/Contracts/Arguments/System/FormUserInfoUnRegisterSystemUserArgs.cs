using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class FormUserInfoUnRegisterSystemUserArgs : IContractArgs
	{
		private String _userId;
		private String _systemId;
		private String _ipAddr;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String SystemId
		{
			get { return this._systemId; }
			set { this._systemId = value; }
		}

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public FormUserInfoUnRegisterSystemUserArgs() { }

		public FormUserInfoUnRegisterSystemUserArgs(String userId, String systemId, String ipAddr)
		{
			this._userId = userId;
			this._systemId = systemId;
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new FormUserInfoUnRegisterSystemUserRequest();
		}
	}
}