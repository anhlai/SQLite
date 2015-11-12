using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00GrdJukyongDateArgs : IContractArgs
	{
		private String _jundalTable;
		private String _jundalPart;
		private String _gumsaja;

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

		public String Gumsaja
		{
			get { return this._gumsaja; }
			set { this._gumsaja = value; }
		}

		public SCH3001U00GrdJukyongDateArgs() { }

		public SCH3001U00GrdJukyongDateArgs(String jundalTable, String jundalPart, String gumsaja)
		{
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._gumsaja = gumsaja;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00GrdJukyongDateRequest();
		}
	}
}