using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01CheckIsSameNameYnArgs : IContractArgs
	{
		private String _naewonDate;
		private String _gwa;
		private String _naewonYn;
		private String _reserYn;
		private String _doctorModeYn;
		private String _doctor;
		private String _bunho;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String NaewonYn
		{
			get { return this._naewonYn; }
			set { this._naewonYn = value; }
		}

		public String ReserYn
		{
			get { return this._reserYn; }
			set { this._reserYn = value; }
		}

		public String DoctorModeYn
		{
			get { return this._doctorModeYn; }
			set { this._doctorModeYn = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public OcsoOCS1003P01CheckIsSameNameYnArgs() { }

		public OcsoOCS1003P01CheckIsSameNameYnArgs(String naewonDate, String gwa, String naewonYn, String reserYn, String doctorModeYn, String doctor, String bunho)
		{
			this._naewonDate = naewonDate;
			this._gwa = gwa;
			this._naewonYn = naewonYn;
			this._reserYn = reserYn;
			this._doctorModeYn = doctorModeYn;
			this._doctor = doctor;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01CheckIsSameNameYnRequest();
		}
	}
}