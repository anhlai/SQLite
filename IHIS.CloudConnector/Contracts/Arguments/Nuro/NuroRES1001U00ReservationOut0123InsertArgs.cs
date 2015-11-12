using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReservationOut0123InsertArgs : IContractArgs
	{
		private String _userId;
		private String _patientCode;
		private String _departmentCode;
		private String _doctorCode;
		private String _examPreDate;
		private String _examPreTime;
		private String _reserComment;
		private String _pkout1001;
		private String _reserType;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

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

		public String ReserComment
		{
			get { return this._reserComment; }
			set { this._reserComment = value; }
		}

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public String ReserType
		{
			get { return this._reserType; }
			set { this._reserType = value; }
		}

		public NuroRES1001U00ReservationOut0123InsertArgs() { }

		public NuroRES1001U00ReservationOut0123InsertArgs(String userId, String patientCode, String departmentCode, String doctorCode, String examPreDate, String examPreTime, String reserComment, String pkout1001, String reserType)
		{
			this._userId = userId;
			this._patientCode = patientCode;
			this._departmentCode = departmentCode;
			this._doctorCode = doctorCode;
			this._examPreDate = examPreDate;
			this._examPreTime = examPreTime;
			this._reserComment = reserComment;
			this._pkout1001 = pkout1001;
			this._reserType = reserType;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReservationOut0123InsertRequest();
		}
	}
}