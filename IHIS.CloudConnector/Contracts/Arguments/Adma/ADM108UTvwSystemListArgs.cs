using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM108UTvwSystemListArgs : IContractArgs
	{
		private String _pgmId;

		public String PgmId
		{
			get { return this._pgmId; }
			set { this._pgmId = value; }
		}

		public ADM108UTvwSystemListArgs() { }

		public ADM108UTvwSystemListArgs(String pgmId)
		{
			this._pgmId = pgmId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM108UTvwSystemListRequest();
		}
	}
}