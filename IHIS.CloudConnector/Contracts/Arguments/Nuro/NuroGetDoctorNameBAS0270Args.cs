using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroGetDoctorNameBAS0270Args : IContractArgs
	{
		private String _doctor;
		private String _gwa;
		private String _naewonDate;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
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

		public NuroGetDoctorNameBAS0270Args() { }

		public NuroGetDoctorNameBAS0270Args(String doctor, String gwa, String naewonDate)
		{
			this._doctor = doctor;
			this._gwa = gwa;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroGetDoctorNameBAS0270Request();
		}
	}
}