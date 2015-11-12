using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class DupCheckCPLOrder1RequestInfo
	{
		private String _newHangmogCode;
		private String _newSpecimenCode;
		private String _oldHangmogCode;
		private String _oldSpecimenCode;

		public String NewHangmogCode
		{
			get { return this._newHangmogCode; }
			set { this._newHangmogCode = value; }
		}

		public String NewSpecimenCode
		{
			get { return this._newSpecimenCode; }
			set { this._newSpecimenCode = value; }
		}

		public String OldHangmogCode
		{
			get { return this._oldHangmogCode; }
			set { this._oldHangmogCode = value; }
		}

		public String OldSpecimenCode
		{
			get { return this._oldSpecimenCode; }
			set { this._oldSpecimenCode = value; }
		}

		public DupCheckCPLOrder1RequestInfo() { }

		public DupCheckCPLOrder1RequestInfo(String newHangmogCode, String newSpecimenCode, String oldHangmogCode, String oldSpecimenCode)
		{
			this._newHangmogCode = newHangmogCode;
			this._newSpecimenCode = newSpecimenCode;
			this._oldHangmogCode = oldHangmogCode;
			this._oldSpecimenCode = oldSpecimenCode;
		}

	}
}