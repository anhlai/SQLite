using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00DoctorExamStatusArgs : IContractArgs
	{
		private String _type;
		private String _examPreDate;
		private String _examPreTime;
		private String _doctorCode;

		public String Type
		{
			get { return this._type; }
			set { this._type = value; }
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

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public NuroRES1001U00DoctorExamStatusArgs() { }

		public NuroRES1001U00DoctorExamStatusArgs(String type, String examPreDate, String examPreTime, String doctorCode)
		{
			this._type = type;
			this._examPreDate = examPreDate;
			this._examPreTime = examPreTime;
			this._doctorCode = doctorCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00DoctorExamStatusRequest();
		}
	}
}