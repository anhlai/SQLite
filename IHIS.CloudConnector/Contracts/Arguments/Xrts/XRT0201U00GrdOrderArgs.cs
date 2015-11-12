using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00GrdOrderArgs : IContractArgs
	{
		private String _ioGubun;
		private String _actGubun;
		private String _reserYn;
		private String _orderDate;
		private String _fromDate;
		private String _toDate;
		private String _naewonKey;
		private String _emergency;
		private String _jundalTableCode;
		private String _jundalPart;
		private String _bunho;
		private String _doctor;

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

		public String ReserYn
		{
			get { return this._reserYn; }
			set { this._reserYn = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
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

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public String Emergency
		{
			get { return this._emergency; }
			set { this._emergency = value; }
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

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public XRT0201U00GrdOrderArgs() { }

		public XRT0201U00GrdOrderArgs(String ioGubun, String actGubun, String reserYn, String orderDate, String fromDate, String toDate, String naewonKey, String emergency, String jundalTableCode, String jundalPart, String bunho, String doctor)
		{
			this._ioGubun = ioGubun;
			this._actGubun = actGubun;
			this._reserYn = reserYn;
			this._orderDate = orderDate;
			this._fromDate = fromDate;
			this._toDate = toDate;
			this._naewonKey = naewonKey;
			this._emergency = emergency;
			this._jundalTableCode = jundalTableCode;
			this._jundalPart = jundalPart;
			this._bunho = bunho;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00GrdOrderRequest();
		}
	}
}