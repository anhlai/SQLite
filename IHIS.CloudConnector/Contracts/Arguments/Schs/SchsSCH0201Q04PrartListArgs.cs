using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q04PrartListArgs : IContractArgs
	{
		private String _jundalTable;

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public SchsSCH0201Q04PrartListArgs() { }

		public SchsSCH0201Q04PrartListArgs(String jundalTable)
		{
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q04PrartListRequest();
		}
	}
}