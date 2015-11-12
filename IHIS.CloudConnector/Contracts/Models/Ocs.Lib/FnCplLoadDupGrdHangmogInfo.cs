using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class FnCplLoadDupGrdHangmogInfo
	{
		private String _hangmogCode1;
		private String _specimenCode1;
		private String _hangmogCode2;
		private String _specimenCode2;

		public String HangmogCode1
		{
			get { return this._hangmogCode1; }
			set { this._hangmogCode1 = value; }
		}

		public String SpecimenCode1
		{
			get { return this._specimenCode1; }
			set { this._specimenCode1 = value; }
		}

		public String HangmogCode2
		{
			get { return this._hangmogCode2; }
			set { this._hangmogCode2 = value; }
		}

		public String SpecimenCode2
		{
			get { return this._specimenCode2; }
			set { this._specimenCode2 = value; }
		}

		public FnCplLoadDupGrdHangmogInfo() { }

		public FnCplLoadDupGrdHangmogInfo(String hangmogCode1, String specimenCode1, String hangmogCode2, String specimenCode2)
		{
			this._hangmogCode1 = hangmogCode1;
			this._specimenCode1 = specimenCode1;
			this._hangmogCode2 = hangmogCode2;
			this._specimenCode2 = specimenCode2;
		}

	}
}