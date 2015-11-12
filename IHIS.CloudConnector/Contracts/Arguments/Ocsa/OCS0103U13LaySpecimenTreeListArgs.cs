using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U13LaySpecimenTreeListArgs : IContractArgs
	{
		private String _user;

		public String User
		{
			get { return this._user; }
			set { this._user = value; }
		}

		public OCS0103U13LaySpecimenTreeListArgs() { }

		public OCS0103U13LaySpecimenTreeListArgs(String user)
		{
			this._user = user;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U13LaySpecimenTreeListRequest();
		}
	}
}