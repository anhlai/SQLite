using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroLoadTableReserYNArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _naewonDate;
		private String _doctor;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public NuroLoadTableReserYNArgs() { }

		public NuroLoadTableReserYNArgs(String bunho, String gwa, String naewonDate, String doctor)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._naewonDate = naewonDate;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroLoadTableReserYNRequest();
		}
	}
}