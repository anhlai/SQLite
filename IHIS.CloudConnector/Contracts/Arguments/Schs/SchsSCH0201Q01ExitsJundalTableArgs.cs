using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q01ExitsJundalTableArgs : IContractArgs
	{
		private String _hangmogCode;
		private String _jundalTable;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public SchsSCH0201Q01ExitsJundalTableArgs() { }

		public SchsSCH0201Q01ExitsJundalTableArgs(String hangmogCode, String jundalTable)
		{
			this._hangmogCode = hangmogCode;
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01ExitsJundalTableRequest();
		}
	}
}