using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00ReseredDataListArgs : IContractArgs
	{
		private String _departmentCode;
		private String _doctorCode;
		private String _examPreDate;
		private String _fromTime;
		private String _reserFromTime;
		private String _toTime;
		private String _reserToTime;

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

		public String FromTime
		{
			get { return this._fromTime; }
			set { this._fromTime = value; }
		}

		public String ReserFromTime
		{
			get { return this._reserFromTime; }
			set { this._reserFromTime = value; }
		}

		public String ToTime
		{
			get { return this._toTime; }
			set { this._toTime = value; }
		}

		public String ReserToTime
		{
			get { return this._reserToTime; }
			set { this._reserToTime = value; }
		}

		public NuroRES1001U00ReseredDataListArgs() { }

		public NuroRES1001U00ReseredDataListArgs(String departmentCode, String doctorCode, String examPreDate, String fromTime, String reserFromTime, String toTime, String reserToTime)
		{
			this._departmentCode = departmentCode;
			this._doctorCode = doctorCode;
			this._examPreDate = examPreDate;
			this._fromTime = fromTime;
			this._reserFromTime = reserFromTime;
			this._toTime = toTime;
			this._reserToTime = reserToTime;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00ReseredDataListRequest();
		}
	}
}