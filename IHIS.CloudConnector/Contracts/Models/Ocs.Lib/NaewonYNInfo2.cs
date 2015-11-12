using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class NaewonYNInfo2
	{
		private String _pkout1001;

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public NaewonYNInfo2() { }

		public NaewonYNInfo2(String pkout1001)
		{
			this._pkout1001 = pkout1001;
		}

	}
}