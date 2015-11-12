using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q01ReserListCboArgs : IContractArgs
	{
		private String _fromDate;
		private String _toDate;
		private String _jundalTable;
		private String _jundalPart;
		private Boolean _chkchecked;
		private Boolean _isSelectedGumsa;

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

		public Boolean Chkchecked
		{
			get { return this._chkchecked; }
			set { this._chkchecked = value; }
		}

		public Boolean IsSelectedGumsa
		{
			get { return this._isSelectedGumsa; }
			set { this._isSelectedGumsa = value; }
		}

		public SchsSCH0201Q01ReserListCboArgs() { }

		public SchsSCH0201Q01ReserListCboArgs(String fromDate, String toDate, String jundalTable, String jundalPart, Boolean chkchecked, Boolean isSelectedGumsa)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._jundalTable = jundalTable;
			this._jundalPart = jundalPart;
			this._chkchecked = chkchecked;
			this._isSelectedGumsa = isSelectedGumsa;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q01ReserListCboRequest();
		}
	}
}