using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00CheckingHangmogCodeArgs : IContractArgs
	{
		private String _patientCode;
		private String _examPreDate;
		private String _departmentCode;
		private String _doctorCode;

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

		public String DepartmentCode
		{
			get { return this._departmentCode; }
			set { this._departmentCode = value; }
		}

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public NuroRES1001U00CheckingHangmogCodeArgs() { }

		public NuroRES1001U00CheckingHangmogCodeArgs(String patientCode, String examPreDate, String departmentCode, String doctorCode)
		{
			this._patientCode = patientCode;
			this._examPreDate = examPreDate;
			this._departmentCode = departmentCode;
			this._doctorCode = doctorCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00CheckingHangmogCodeRequest();
		}
	}
}