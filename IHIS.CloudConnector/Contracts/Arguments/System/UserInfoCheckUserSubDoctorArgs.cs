using System;
using ProtoBuf;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class UserInfoCheckUserSubDoctorArgs : IContractArgs
	{
		private String _gwa;
		private UserRequestInfo _userInfo;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public UserRequestInfo UserInfo
		{
			get { return this._userInfo; }
			set { this._userInfo = value; }
		}

		public UserInfoCheckUserSubDoctorArgs() { }

		public UserInfoCheckUserSubDoctorArgs(String gwa, UserRequestInfo userInfo)
		{
			this._gwa = gwa;
			this._userInfo = userInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.UserInfoCheckUserSubDoctorRequest();
		}
	}
}