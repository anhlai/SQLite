using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99ComboGumsaPartArgs : IContractArgs
	{
		private String _jundalTable;

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public SchsSCH0201U99ComboGumsaPartArgs() { }

		public SchsSCH0201U99ComboGumsaPartArgs(String jundalTable)
		{
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99ComboGumsaPartRequest();
		}
	}
}