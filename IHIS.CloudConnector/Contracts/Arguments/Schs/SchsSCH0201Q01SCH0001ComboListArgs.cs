using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q01SCH0001ComboListArgs : IContractArgs
	{
		private String _jundalTable;

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public SchsSCH0201Q01SCH0001ComboListArgs() { }

		public SchsSCH0201Q01SCH0001ComboListArgs(String jundalTable)
		{
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01SCH0001ComboListRequest();
		}
	}
}