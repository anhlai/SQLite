using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Chts
{
	public class CHT0110Q01GrdCHT0110MListArgs : IContractArgs
	{
		private String _sangInx;
		private String _date;
		private String _ioGubun;
		private String _userId;

		public String SangInx
		{
			get { return this._sangInx; }
			set { this._sangInx = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CHT0110Q01GrdCHT0110MListArgs() { }

		public CHT0110Q01GrdCHT0110MListArgs(String sangInx, String date, String ioGubun, String userId)
		{
			this._sangInx = sangInx;
			this._date = date;
			this._ioGubun = ioGubun;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CHT0110Q01GrdCHT0110MListRequest();
		}
	}
}