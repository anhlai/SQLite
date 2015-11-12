using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class DupCheckCPLOrder2RequestInfo
	{
		private String _ioGubun;
		private String _bunho;
		private String _hangmogCode;
		private String _specimenCode;
		private String _checkDate;

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

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

		public String SpecimenCode
		{
			get { return this._specimenCode; }
			set { this._specimenCode = value; }
		}

		public String CheckDate
		{
			get { return this._checkDate; }
			set { this._checkDate = value; }
		}

		public DupCheckCPLOrder2RequestInfo() { }

		public DupCheckCPLOrder2RequestInfo(String ioGubun, String bunho, String hangmogCode, String specimenCode, String checkDate)
		{
			this._ioGubun = ioGubun;
			this._bunho = bunho;
			this._hangmogCode = hangmogCode;
			this._specimenCode = specimenCode;
			this._checkDate = checkDate;
		}

	}
}