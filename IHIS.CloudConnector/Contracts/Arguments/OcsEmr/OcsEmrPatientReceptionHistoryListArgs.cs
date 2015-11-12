using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OcsEmrPatientReceptionHistoryListArgs : IContractArgs
	{
		private String _patientCode;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public OcsEmrPatientReceptionHistoryListArgs() { }

		public OcsEmrPatientReceptionHistoryListArgs(String patientCode)
		{
			this._patientCode = patientCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsEmrPatientReceptionHistoryListRequest();
		}
	}
}