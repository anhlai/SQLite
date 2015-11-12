using System;
using IHIS.CloudConnector.Contracts.Models.System;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class CheckUserLoginArgs : IContractArgs
	{
		private String _userId;
		private String _systemId;
		private UserRequestInfo _userInfo;

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

		public UserRequestInfo UserInfo
		{
			get { return this._userInfo; }
			set { this._userInfo = value; }
		}

		public CheckUserLoginArgs() { }

		public CheckUserLoginArgs(String userId, String systemId, UserRequestInfo userInfo)
		{
			this._userId = userId;
			this._systemId = systemId;
			this._userInfo = userInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.CheckUserLoginRequest();
		}
	}
}