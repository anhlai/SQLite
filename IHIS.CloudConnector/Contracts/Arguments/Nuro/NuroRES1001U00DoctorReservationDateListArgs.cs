using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00DoctorReservationDateListArgs : IContractArgs
	{
		private String _doctorCode;
		private String _startDate;
		private String _endDate;

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public String StartDate
		{
			get { return this._startDate; }
			set { this._startDate = value; }
		}

		public String EndDate
		{
			get { return this._endDate; }
			set { this._endDate = value; }
		}

		public NuroRES1001U00DoctorReservationDateListArgs() { }

		public NuroRES1001U00DoctorReservationDateListArgs(String doctorCode, String startDate, String endDate)
		{
			this._doctorCode = doctorCode;
			this._startDate = startDate;
			this._endDate = endDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00DoctorReservationDateListRequest();
		}
	}
}