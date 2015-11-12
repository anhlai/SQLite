using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00CheckingReservationArgs : IContractArgs
	{
		private String _doctorCode;
		private String _examPreDate;
		private String _examPreTime;
		private String _inputType;

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public String ExamPreDate
		{
			get { return this._examPreDate; }
			set { this._examPreDate = value; }
		}

		public String ExamPreTime
		{
			get { return this._examPreTime; }
			set { this._examPreTime = value; }
		}

		public String InputType
		{
			get { return this._inputType; }
			set { this._inputType = value; }
		}

		public NuroRES1001U00CheckingReservationArgs() { }

		public NuroRES1001U00CheckingReservationArgs(String doctorCode, String examPreDate, String examPreTime, String inputType)
		{
			this._doctorCode = doctorCode;
			this._examPreDate = examPreDate;
			this._examPreTime = examPreTime;
			this._inputType = inputType;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00CheckingReservationRequest();
		}
	}
}