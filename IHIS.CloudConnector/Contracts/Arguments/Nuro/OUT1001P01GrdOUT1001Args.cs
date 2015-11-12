using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT1001P01GrdOUT1001Args : IContractArgs
	{
		private String _naewonDate;
		private String _bunho;
		private String _pkout1001;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public OUT1001P01GrdOUT1001Args() { }

		public OUT1001P01GrdOUT1001Args(String naewonDate, String bunho, String pkout1001)
		{
			this._naewonDate = naewonDate;
			this._bunho = bunho;
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT1001P01GrdOUT1001Request();
		}
	}
}