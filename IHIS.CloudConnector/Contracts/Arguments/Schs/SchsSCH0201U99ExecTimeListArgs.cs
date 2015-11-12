using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99ExecTimeListArgs : IContractArgs
	{
		private String _iIpAddress;
		private String _iJundalTable;
		private String _iJundalPart;
		private String _iGumsaja;
		private String _iReserDate;

		public String IIpAddress
		{
			get { return this._iIpAddress; }
			set { this._iIpAddress = value; }
		}

		public String IJundalTable
		{
			get { return this._iJundalTable; }
			set { this._iJundalTable = value; }
		}

		public String IJundalPart
		{
			get { return this._iJundalPart; }
			set { this._iJundalPart = value; }
		}

		public String IGumsaja
		{
			get { return this._iGumsaja; }
			set { this._iGumsaja = value; }
		}

		public String IReserDate
		{
			get { return this._iReserDate; }
			set { this._iReserDate = value; }
		}

		public SchsSCH0201U99ExecTimeListArgs() { }

		public SchsSCH0201U99ExecTimeListArgs(String iIpAddress, String iJundalTable, String iJundalPart, String iGumsaja, String iReserDate)
		{
			this._iIpAddress = iIpAddress;
			this._iJundalTable = iJundalTable;
			this._iJundalPart = iJundalPart;
			this._iGumsaja = iGumsaja;
			this._iReserDate = iReserDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99ExecTimeListRequest();
		}
	}
}