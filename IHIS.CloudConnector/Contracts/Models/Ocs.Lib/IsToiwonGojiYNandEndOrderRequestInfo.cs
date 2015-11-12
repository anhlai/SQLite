using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class IsToiwonGojiYNandEndOrderRequestInfo
	{
		private String _pkinp1001;

		public String Pkinp1001
		{
			get { return this._pkinp1001; }
			set { this._pkinp1001 = value; }
		}

		public IsToiwonGojiYNandEndOrderRequestInfo() { }

		public IsToiwonGojiYNandEndOrderRequestInfo(String pkinp1001)
		{
			this._pkinp1001 = pkinp1001;
		}

	}
}