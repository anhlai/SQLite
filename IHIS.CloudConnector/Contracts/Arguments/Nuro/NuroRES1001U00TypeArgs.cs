using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroRES1001U00TypeArgs : IContractArgs
	{
		private String _patientCode;
		private String _departmentCode;

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

		public NuroRES1001U00TypeArgs() { }

		public NuroRES1001U00TypeArgs(String patientCode, String departmentCode)
		{
			this._patientCode = patientCode;
			this._departmentCode = departmentCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroRES1001U00TypeRequest();
		}
	}
}