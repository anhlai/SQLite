using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class IsResultToConsultRequestInfo
	{
		private String _pkocskey;
		private String _ioGubun;

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public String IoGubun
		{
			get { return this._ioGubun; }
			set { this._ioGubun = value; }
		}

		public IsResultToConsultRequestInfo() { }

		public IsResultToConsultRequestInfo(String pkocskey, String ioGubun)
		{
			this._pkocskey = pkocskey;
			this._ioGubun = ioGubun;
		}

	}
}