using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99DateScheduleListArgs : IContractArgs
	{
		private String _fStartDate;
		private String _fJundalTable;
		private String _fJundalPart;
		private String _fHangmogCode;

		public String FStartDate
		{
			get { return this._fStartDate; }
			set { this._fStartDate = value; }
		}

		public String FJundalTable
		{
			get { return this._fJundalTable; }
			set { this._fJundalTable = value; }
		}

		public String FJundalPart
		{
			get { return this._fJundalPart; }
			set { this._fJundalPart = value; }
		}

		public String FHangmogCode
		{
			get { return this._fHangmogCode; }
			set { this._fHangmogCode = value; }
		}

		public SchsSCH0201U99DateScheduleListArgs() { }

		public SchsSCH0201U99DateScheduleListArgs(String fStartDate, String fJundalTable, String fJundalPart, String fHangmogCode)
		{
			this._fStartDate = fStartDate;
			this._fJundalTable = fJundalTable;
			this._fJundalPart = fJundalPart;
			this._fHangmogCode = fHangmogCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99DateScheduleListRequest();
		}
	}
}