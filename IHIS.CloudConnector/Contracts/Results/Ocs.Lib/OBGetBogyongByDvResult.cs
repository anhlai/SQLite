using System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBGetBogyongByDvResult : AbstractContractResult
	{
		private String _dv;
		private String _gubun;

		public String Dv
		{
			get { return this._dv; }
			set { this._dv = value; }
		}

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public OBGetBogyongByDvResult() { }

	}
}