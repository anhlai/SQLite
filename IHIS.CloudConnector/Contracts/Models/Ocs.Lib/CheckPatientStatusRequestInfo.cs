using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class CheckPatientStatusRequestInfo
	{
		private String _bunho;
		private String _hangmogCode;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public CheckPatientStatusRequestInfo() { }

		public CheckPatientStatusRequestInfo(String bunho, String hangmogCode)
		{
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
		}

	}
}