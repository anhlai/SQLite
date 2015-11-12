using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U04LoadExaminationArgs : IContractArgs
	{
		private String _patientCode;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public OCS2015U04LoadExaminationArgs() { }

		public OCS2015U04LoadExaminationArgs(String patientCode)
		{
			this._patientCode = patientCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U04LoadExaminationRequest();
		}
	}
}