using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q02ReserList02Args : IContractArgs
	{
		private String _fromDate;
		private String _toDate;
		private String _gwa;

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

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public SchsSCH0201Q02ReserList02Args() { }

		public SchsSCH0201Q02ReserList02Args(String fromDate, String toDate, String gwa)
		{
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q02ReserList02Request();
		}
	}
}