using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q04GetFormLoadArgs : IContractArgs
	{
		private String _month;
		private String _jundalTable;
		private String _jundalPart;

		public String Month
		{
			get { return this._month; }
			set { this._month = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public SchsSCH0201Q04GetFormLoadArgs() { }

		public SchsSCH0201Q04GetFormLoadArgs(String month, String jundalTable, String jundalPart)
		{
			this._month = month;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q04GetFormLoadRequest();
		}
	}
}