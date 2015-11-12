using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00DoctorReserListArgs : IContractArgs
	{
		private String _patientCode;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public NuroRES1001U00DoctorReserListArgs() { }

		public NuroRES1001U00DoctorReserListArgs(String patientCode)
		{
			this._patientCode = patientCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00DoctorReserListRequest();
		}
	}
}