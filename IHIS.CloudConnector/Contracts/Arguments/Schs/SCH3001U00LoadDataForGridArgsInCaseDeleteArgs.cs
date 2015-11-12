using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH3001U00LoadDataForGridArgsInCaseDeleteArgs : IContractArgs
	{
		private String _jukyongDate;
		private String _jundalTable;
		private String _jundalPart;
		private String _gumsaja;
		private String _yoilGubun;

		public String JukyongDate
		{
			get { return this._jukyongDate; }
			set { this._jukyongDate = value; }
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

		public String Gumsaja
		{
			get { return this._gumsaja; }
			set { this._gumsaja = value; }
		}

		public String YoilGubun
		{
			get { return this._yoilGubun; }
			set { this._yoilGubun = value; }
		}

		public SCH3001U00LoadDataForGridArgsInCaseDeleteArgs() { }

		public SCH3001U00LoadDataForGridArgsInCaseDeleteArgs(String jukyongDate, String jundalTable, String jundalPart, String gumsaja, String yoilGubun)
		{
			this._jukyongDate = jukyongDate;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._gumsaja = gumsaja;
			this._yoilGubun = yoilGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH3001U00LoadDataForGridRequestInCaseDeleteRequest();
		}
	}
}