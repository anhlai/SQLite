using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT1001U01LoadCheckChojaeJpnArgs : IContractArgs
	{
		private String _naewonDate;
		private String _bunho;
		private String _gubun;
		private String _gwa;
		private String _jubsuNo;

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

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String JubsuNo
		{
			get { return this._jubsuNo; }
			set { this._jubsuNo = value; }
		}

		public NuroOUT1001U01LoadCheckChojaeJpnArgs() { }

		public NuroOUT1001U01LoadCheckChojaeJpnArgs(String naewonDate, String bunho, String gubun, String gwa, String jubsuNo)
		{
			this._naewonDate = naewonDate;
			this._bunho = bunho;
			this._gubun = gubun;
			this._gwa = gwa;
			this._jubsuNo = jubsuNo;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT1001U01LoadCheckChojaeJpnRequest();
		}
	}
}