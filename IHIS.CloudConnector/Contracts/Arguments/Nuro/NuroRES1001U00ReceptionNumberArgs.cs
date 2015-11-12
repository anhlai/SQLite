using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReceptionNumberArgs : IContractArgs
	{
		private String _patientCode;
		private String _examPreDate;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public String ExamPreDate
		{
			get { return this._examPreDate; }
			set { this._examPreDate = value; }
		}

		public NuroRES1001U00ReceptionNumberArgs() { }

		public NuroRES1001U00ReceptionNumberArgs(String patientCode, String examPreDate)
		{
			this._patientCode = patientCode;
			this._examPreDate = examPreDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReceptionNumberRequest();
		}
	}
}