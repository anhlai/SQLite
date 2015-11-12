using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01LayPatArgs : IContractArgs
	{
		private String _fDoctor;
		private String _fBunho;
		private String _fNaewonDate;
		private String _fLoginDoctorYn;

		public String FDoctor
		{
			get { return this._fDoctor; }
			set { this._fDoctor = value; }
		}

		public String FBunho
		{
			get { return this._fBunho; }
			set { this._fBunho = value; }
		}

		public String FNaewonDate
		{
			get { return this._fNaewonDate; }
			set { this._fNaewonDate = value; }
		}

		public String FLoginDoctorYn
		{
			get { return this._fLoginDoctorYn; }
			set { this._fLoginDoctorYn = value; }
		}

		public OcsoOCS1003P01LayPatArgs() { }

		public OcsoOCS1003P01LayPatArgs(String fDoctor, String fBunho, String fNaewonDate, String fLoginDoctorYn)
		{
			this._fDoctor = fDoctor;
			this._fBunho = fBunho;
			this._fNaewonDate = fNaewonDate;
			this._fLoginDoctorYn = fLoginDoctorYn;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01LayPatRequest();
		}
	}
}