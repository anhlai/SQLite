using System;
using IHIS.CloudConnector.Contracts.Models.System;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class UserInfoCheckUserSubArgs : IContractArgs
	{
		private UserRequestInfo _userInfo;

		public UserRequestInfo UserInfo
		{
			get { return this._userInfo; }
			set { this._userInfo = value; }
		}

		public UserInfoCheckUserSubArgs() { }

		public UserInfoCheckUserSubArgs(UserRequestInfo userInfo)
		{
			this._userInfo = userInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.UserInfoCheckUserSubRequest();
		}
	}
}