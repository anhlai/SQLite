using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00CheckingPatientExistenceArgs : IContractArgs
	{
		private String _patientCode;
		private String _pkout1001;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public NuroRES1001U00CheckingPatientExistenceArgs() { }

		public NuroRES1001U00CheckingPatientExistenceArgs(String patientCode, String pkout1001)
		{
			this._patientCode = patientCode;
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00CheckingPatientExistenceRequest();
		}
	}
}