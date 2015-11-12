using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReservationScheduleListArgs : IContractArgs
	{
		private String _examPreDate;
		private String _departmentCode;
		private String _doctorCode;
		private String _fromTime;
		private String _toTime;
		private String _avgTime;

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

		public String FromTime
		{
			get { return this._fromTime; }
			set { this._fromTime = value; }
		}

		public String ToTime
		{
			get { return this._toTime; }
			set { this._toTime = value; }
		}

		public String AvgTime
		{
			get { return this._avgTime; }
			set { this._avgTime = value; }
		}

		public NuroRES1001U00ReservationScheduleListArgs() { }

		public NuroRES1001U00ReservationScheduleListArgs(String examPreDate, String departmentCode, String doctorCode, String fromTime, String toTime, String avgTime)
		{
			this._examPreDate = examPreDate;
			this._departmentCode = departmentCode;
			this._doctorCode = doctorCode;
			this._fromTime = fromTime;
			this._toTime = toTime;
			this._avgTime = avgTime;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReservationScheduleListRequest();
		}
	}
}