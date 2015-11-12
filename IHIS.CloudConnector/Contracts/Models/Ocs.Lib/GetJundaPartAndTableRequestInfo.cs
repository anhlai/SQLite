using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetJundaPartAndTableRequestInfo
	{
		private String _hangmogCode;
		private String _inputPart;
		private String _inputGwa;
		private String _appDate;

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String InputPart
		{
			get { return this._inputPart; }
			set { this._inputPart = value; }
		}

		public String InputGwa
		{
			get { return this._inputGwa; }
			set { this._inputGwa = value; }
		}

		public String AppDate
		{
			get { return this._appDate; }
			set { this._appDate = value; }
		}

		public GetJundaPartAndTableRequestInfo() { }

		public GetJundaPartAndTableRequestInfo(String hangmogCode, String inputPart, String inputGwa, String appDate)
		{
			this._hangmogCode = hangmogCode;
			this._inputPart = inputPart;
			this._inputGwa = inputGwa;
			this._appDate = appDate;
		}

	}
}