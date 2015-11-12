using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00PRDoctorScheduleNewArgs : IContractArgs
	{
		private String _iDoctor;
		private String _iYymm;

		public String IDoctor
		{
			get { return this._iDoctor; }
			set { this._iDoctor = value; }
		}

		public String IYymm
		{
			get { return this._iYymm; }
			set { this._iYymm = value; }
		}

		public NuroRES1001U00PRDoctorScheduleNewArgs() { }

		public NuroRES1001U00PRDoctorScheduleNewArgs(String iDoctor, String iYymm)
		{
			this._iDoctor = iDoctor;
			this._iYymm = iYymm;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00PRDoctorScheduleNewRequest();
		}
	}
}