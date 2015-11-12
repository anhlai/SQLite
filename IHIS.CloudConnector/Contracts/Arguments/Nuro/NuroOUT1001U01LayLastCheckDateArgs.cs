using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT1001U01LayLastCheckDateArgs : IContractArgs
	{
		private String _gubun;
		private String _bunho;
		private String _date;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public NuroOUT1001U01LayLastCheckDateArgs() { }

		public NuroOUT1001U01LayLastCheckDateArgs(String gubun, String bunho, String date)
		{
			this._gubun = gubun;
			this._bunho = bunho;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT1001U01LayLastCheckDateRequest();
		}
	}
}