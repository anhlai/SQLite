using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00AverageTimeListArgs : IContractArgs
	{
		private String _doctorCode;
		private String _examPreDate;

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

		public NuroRES1001U00AverageTimeListArgs() { }

		public NuroRES1001U00AverageTimeListArgs(String doctorCode, String examPreDate)
		{
			this._doctorCode = doctorCode;
			this._examPreDate = examPreDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00AverageTimeListRequest();
		}
	}
}