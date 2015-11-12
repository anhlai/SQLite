using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00GrdSCH0001Args : IContractArgs
	{
		private String _jundalTable;

		public String JundalTable
		{
			get { return this._jundalTable; }
			set { this._jundalTable = value; }
		}

		public SCH3001U00GrdSCH0001Args() { }

		public SCH3001U00GrdSCH0001Args(String jundalTable)
		{
			this._jundalTable = jundalTable;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00GrdSCH0001Request();
		}
	}
}