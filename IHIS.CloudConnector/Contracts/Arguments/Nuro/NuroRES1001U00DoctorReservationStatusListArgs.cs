using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00DoctorReservationStatusListArgs : IContractArgs
	{
		private String _doctorCode;
		private String _departmentCode;

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public String DepartmentCode
		{
			get { return this._departmentCode; }
			set { this._departmentCode = value; }
		}

		public NuroRES1001U00DoctorReservationStatusListArgs() { }

		public NuroRES1001U00DoctorReservationStatusListArgs(String doctorCode, String departmentCode)
		{
			this._doctorCode = doctorCode;
			this._departmentCode = departmentCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00DoctorReservationStatusListRequest();
		}
	}
}