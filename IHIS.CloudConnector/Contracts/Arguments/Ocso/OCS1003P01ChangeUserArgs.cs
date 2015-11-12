using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01ChangeUserArgs : IContractArgs
	{
		private String _gwa;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public OCS1003P01ChangeUserArgs() { }

		public OCS1003P01ChangeUserArgs(String gwa)
		{
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01ChangeUserRequest();
		}
	}
}