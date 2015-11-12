using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01GrdOCS1003Args : IContractArgs
	{
		private String _hospCode;
		private String _language;
		private String _bunho;
		private String _startDate;
		private String _endDate;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String Language
		{
			get { return this._language; }
			set { this._language = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public String EndDate
		{
			get { return this._endDate; }
			set { this._endDate = value; }
		}

		public INJ1001U01GrdOCS1003Args() { }

		public INJ1001U01GrdOCS1003Args(String hospCode, String language, String bunho, String startDate, String endDate)
		{
			this._hospCode = hospCode;
			this._language = language;
			this._bunho = bunho;
			this._startDate = startDate;
			this._endDate = endDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01GrdOCS1003Request();
		}
	}
}