using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
    [Serializable]
	public class FormGwaListArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public FormGwaListArgs() { }

		public FormGwaListArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new FormGwaListRequest();
		}
	}
}