using System;

namespace IHIS.CloudConnector.Contracts.Models.Ocs.Lib
{
	public class NaewonYNInfo1
	{
		private String _bunho;
		private String _naewonDate;
		private String _pkout1001;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public NaewonYNInfo1() { }

		public NaewonYNInfo1(String bunho, String naewonDate, String pkout1001)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
			this._pkout1001 = pkout1001;
		}

	}
}