using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00DoctorNameArgs : IContractArgs
	{
		private String _patientCode;
		private String _departmentCode;
		private String _examPreDate;
		private String _examPreTime;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public String DepartmentCode
		{
			get { return this._departmentCode; }
			set { this._departmentCode = value; }
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

		public NuroRES1001U00DoctorNameArgs() { }

		public NuroRES1001U00DoctorNameArgs(String patientCode, String departmentCode, String examPreDate, String examPreTime)
		{
			this._patientCode = patientCode;
			this._departmentCode = departmentCode;
			this._examPreDate = examPreDate;
			this._examPreTime = examPreTime;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00DoctorNameRequest();
		}
	}
}