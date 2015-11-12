using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class RES1001U00ReservationScheduleListGroupedArgs : IContractArgs
	{
		private String _examPreDate;
		private String _departmentCode;
		private String _doctorCode;
		private String _fromTimeAm;
		private String _toTimeAm;
		private String _fromTimePm;
		private String _toTimePm;
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

		public String FromTimeAm
		{
			get { return this._fromTimeAm; }
			set { this._fromTimeAm = value; }
		}

		public String ToTimeAm
		{
			get { return this._toTimeAm; }
			set { this._toTimeAm = value; }
		}

		public String FromTimePm
		{
			get { return this._fromTimePm; }
			set { this._fromTimePm = value; }
		}

		public String ToTimePm
		{
			get { return this._toTimePm; }
			set { this._toTimePm = value; }
		}

		public String AvgTime
		{
			get { return this._avgTime; }
			set { this._avgTime = value; }
		}

		public RES1001U00ReservationScheduleListGroupedArgs() { }

		public RES1001U00ReservationScheduleListGroupedArgs(String examPreDate, String departmentCode, String doctorCode, String fromTimeAm, String toTimeAm, String fromTimePm, String toTimePm, String avgTime)
		{
			this._examPreDate = examPreDate;
			this._departmentCode = departmentCode;
			this._doctorCode = doctorCode;
			this._fromTimeAm = fromTimeAm;
			this._toTimeAm = toTimeAm;
			this._fromTimePm = fromTimePm;
			this._toTimePm = toTimePm;
			this._avgTime = avgTime;
		}

		public IExtensible GetRequestInstance()
		{
			return new RES1001U00ReservationScheduleListGroupedRequest();
		}
	}
}