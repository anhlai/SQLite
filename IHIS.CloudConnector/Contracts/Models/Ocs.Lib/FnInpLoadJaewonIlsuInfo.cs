using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class FnInpLoadJaewonIlsuInfo
	{
		private String _cpCode;
		private String _appDate;

		public String CpCode
		{
			get { return this._cpCode; }
			set { this._cpCode = value; }
		}

		public String AppDate
		{
			get { return this._appDate; }
			set { this._appDate = value; }
		}

		public FnInpLoadJaewonIlsuInfo() { }

		public FnInpLoadJaewonIlsuInfo(String cpCode, String appDate)
		{
			this._cpCode = cpCode;
			this._appDate = appDate;
		}

	}
}