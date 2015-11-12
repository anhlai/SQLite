using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM108UGrdListArgs : IContractArgs
	{
		private String _sysId;

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public ADM108UGrdListArgs() { }

		public ADM108UGrdListArgs(String sysId)
		{
			this._sysId = sysId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM108UGrdListRequest();
		}
	}
}