using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOut1001U01CheckDoctorScheduleArgs : IContractArgs
	{
		private String _type;
		private String _naewonDate;
		private String _jubsuTime;
		private String _gwa;
		private String _doctor;

		public String Type
		{
			get { return this._type; }
			set { this._type = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String JubsuTime
		{
			get { return this._jubsuTime; }
			set { this._jubsuTime = value; }
		}

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public NuroOut1001U01CheckDoctorScheduleArgs() { }

		public NuroOut1001U01CheckDoctorScheduleArgs(String type, String naewonDate, String jubsuTime, String gwa, String doctor)
		{
			this._type = type;
			this._naewonDate = naewonDate;
			this._jubsuTime = jubsuTime;
			this._gwa = gwa;
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOut1001U01CheckDoctorScheduleRequest();
		}
	}
}