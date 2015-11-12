using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q04PrSchTimeListArgs : IContractArgs
	{
		private String _ipAddr;
		private String _jundalTable;
		private String _jundalPart;
		private String _gumsaja;
		private String _reserDate;

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
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

		public String ReserDate
		{
			get { return this._reserDate; }
			set { this._reserDate = value; }
		}

		public SchsSCH0201Q04PrSchTimeListArgs() { }

		public SchsSCH0201Q04PrSchTimeListArgs(String ipAddr, String jundalTable, String jundalPart, String gumsaja, String reserDate)
		{
			this._ipAddr = ipAddr;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._gumsaja = gumsaja;
			this._reserDate = reserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q04PrSchTimeListRequest();
		}
	}
}