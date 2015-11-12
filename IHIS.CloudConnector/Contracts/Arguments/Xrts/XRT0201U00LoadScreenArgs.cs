using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00LoadScreenArgs : IContractArgs
	{
		private String _queryDate;
		private String _ioGubun;
		private String _actGubun;
		private String _jundalTableCode;
		private String _jundalPart;
		private String _bunho;
		private String _fromDate;
		private String _toDate;

		public String QueryDate
		{
			get { return this._queryDate; }
			set { this._queryDate = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public String ActGubun
		{
			get { return this._actGubun; }
			set { this._actGubun = value; }
		}

		public String JundalTableCode
		{
			get { return this._jundalTableCode; }
			set { this._jundalTableCode = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

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

		public XRT0201U00LoadScreenArgs() { }

		public XRT0201U00LoadScreenArgs(String queryDate, String ioGubun, String actGubun, String jundalTableCode, String jundalPart, String bunho, String fromDate, String toDate)
		{
			this._queryDate = queryDate;
			this._ioGubun = ioGubun;
			this._actGubun = actGubun;
			this._jundalTableCode = jundalTableCode;
			this._jundalPart = jundalPart;
			this._bunho = bunho;
			this._fromDate = fromDate;
			this._toDate = toDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00LoadScreenRequest();
		}
	}
}