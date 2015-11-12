using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0204Q00GetOcsUserNameArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0204Q00GetOcsUserNameArgs() { }

		public OCS0204Q00GetOcsUserNameArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0204Q00GetOcsUserNameRequest();
		}
	}
}