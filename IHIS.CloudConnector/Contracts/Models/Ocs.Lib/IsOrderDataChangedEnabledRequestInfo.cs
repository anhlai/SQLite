using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class IsOrderDataChangedEnabledRequestInfo
	{
		private String _iudGubun;
		private String _aioeGubun;
		private String _pkocskey;

		public String IudGubun
		{
			get { return this._iudGubun; }
			set { this._iudGubun = value; }
		}

		public String AioeGubun
		{
			get { return this._aioeGubun; }
			set { this._aioeGubun = value; }
		}

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public IsOrderDataChangedEnabledRequestInfo() { }

		public IsOrderDataChangedEnabledRequestInfo(String iudGubun, String aioeGubun, String pkocskey)
		{
			this._iudGubun = iudGubun;
			this._aioeGubun = aioeGubun;
			this._pkocskey = pkocskey;
		}

	}
}