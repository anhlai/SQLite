using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01UpdateDoctorArgs : IContractArgs
	{
		private String _doctor;
		private String _gwa;
		private String _pkNaewon;

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

		public String PkNaewon
		{
			get { return this._pkNaewon; }
			set { this._pkNaewon = value; }
		}

		public OcsoOCS1003P01UpdateDoctorArgs() { }

		public OcsoOCS1003P01UpdateDoctorArgs(String doctor, String gwa, String pkNaewon)
		{
			this._doctor = doctor;
			this._gwa = gwa;
			this._pkNaewon = pkNaewon;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01UpdateDoctorRequest();
		}
	}
}