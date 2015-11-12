using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
	public class OUT0106U00PatientInfoNameArgs : IContractArgs
	{
		private String _patientInfo;
		private String _naewonDate;

		public String PatientInfo
		{
			get { return this._patientInfo; }
			set { this._patientInfo = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public OUT0106U00PatientInfoNameArgs() { }

		public OUT0106U00PatientInfoNameArgs(String patientInfo, String naewonDate)
		{
			this._patientInfo = patientInfo;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0106U00PatientInfoNameRequest();
		}
	}
}