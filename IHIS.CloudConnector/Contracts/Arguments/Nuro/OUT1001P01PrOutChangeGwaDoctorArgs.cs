using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OUT1001P01PrOutChangeGwaDoctorArgs : IContractArgs
	{
		private String _gwa;
		private String _bunho;
		private String _pkout1001;
		private String _doctor;
		private String _userId;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
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

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OUT1001P01PrOutChangeGwaDoctorArgs() { }

		public OUT1001P01PrOutChangeGwaDoctorArgs(String gwa, String bunho, String pkout1001, String doctor, String userId)
		{
			this._gwa = gwa;
			this._bunho = bunho;
			this._pkout1001 = pkout1001;
			this._doctor = doctor;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT1001P01PrOutChangeGwaDoctorRequest();
		}
	}
}