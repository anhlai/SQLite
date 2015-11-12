using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class GetJundaTableRequestInfo
	{
		private String _ioeGubun;
		private String _hangmogCode;
		private String _appDate;
		private String _jundalPart;

		public String IoeGubun
		{
			get { return this._ioeGubun; }
			set { this._ioeGubun = value; }
		}

		public String HangmogCode
		{
			get { return this._hangmogCode; }
			set { this._hangmogCode = value; }
		}

		public String AppDate
		{
			get { return this._appDate; }
			set { this._appDate = value; }
		}

		public String JundalPart
		{
			get { return this._jundalPart; }
			set { this._jundalPart = value; }
		}

		public GetJundaTableRequestInfo() { }

		public GetJundaTableRequestInfo(String ioeGubun, String hangmogCode, String appDate, String jundalPart)
		{
			this._ioeGubun = ioeGubun;
			this._hangmogCode = hangmogCode;
			this._appDate = appDate;
			this._jundalPart = jundalPart;
		}

	}
}