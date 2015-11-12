using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroGetRecentlyDoctorArgs : IContractArgs
	{
		private String _bunho;
		private String _gwa;
		private String _naewonDate;

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

		public NuroGetRecentlyDoctorArgs() { }

		public NuroGetRecentlyDoctorArgs(String bunho, String gwa, String naewonDate)
		{
			this._bunho = bunho;
			this._gwa = gwa;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroGetRecentlyDoctorRequest();
		}
	}
}