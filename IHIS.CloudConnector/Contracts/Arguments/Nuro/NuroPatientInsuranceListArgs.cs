using System;
using System.Collections.Generic;
using System.Text;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroPatientInsuranceListArgs : IContractArgs
	{
		private String _patientCode;
		private String _comingDate;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public String ComingDate
		{
			get { return this._comingDate; }
			set { this._comingDate = value; }
		}

		public NuroPatientInsuranceListArgs() { }

		public NuroPatientInsuranceListArgs(String patientCode, String comingDate)
		{
			this._patientCode = patientCode;
			this._comingDate = comingDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroPatientInsuranceListRequest();
		}
	}
}
