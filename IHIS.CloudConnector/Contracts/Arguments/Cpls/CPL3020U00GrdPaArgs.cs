using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00GrdPaArgs : IContractArgs
	{
		private String _gubun;
		private String _jundalGubun;
		private String _fromDate;
		private String _toDate;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String JundalGubun
		{
			get { return this._jundalGubun; }
			set { this._jundalGubun = value; }
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

		public CPL3020U00GrdPaArgs() { }

		public CPL3020U00GrdPaArgs(String gubun, String jundalGubun, String fromDate, String toDate)
		{
			this._gubun = gubun;
			this._jundalGubun = jundalGubun;
			this._fromDate = fromDate;
			this._toDate = toDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00GrdPaRequest();
		}
	}
}