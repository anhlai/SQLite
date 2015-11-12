using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class MdiFormSystemMenuArgs : IContractArgs
	{
		private String _userId;
		private String _systemId;

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

		public MdiFormSystemMenuArgs() { }

		public MdiFormSystemMenuArgs(String userId, String systemId)
		{
			this._userId = userId;
			this._systemId = systemId;
		}

		public IExtensible GetRequestInstance()
		{
			return new MdiFormSystemMenuRequest();
		}
	}
}