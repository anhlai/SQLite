using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q01ReserListArgs : IContractArgs
	{
		private String _fromDate;
		private String _toDate;
		private String _jundalTable;
		private String _jundalPart;
		private Boolean _checked;

		public String FromDate
		{
			get { return this._fromDate; }
			set { this._fromDate = value; }
		}

		public String ToDate
		{
			get { return this._toDate; }
			set { this._toDate = value; }
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

		public Boolean ChkChecked
		{
			get { return this._checked; }
			set { this._checked = value; }
		}

		public SchsSCH0201Q01ReserListArgs() { }

		public SchsSCH0201Q01ReserListArgs(String fromDate, String toDate, String jundalTable, String jundalPart, Boolean chkChecked)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._checked = chkChecked;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01ReserListRequest();
		}
	}
}