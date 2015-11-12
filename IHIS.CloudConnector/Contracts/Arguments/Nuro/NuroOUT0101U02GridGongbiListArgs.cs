using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GridGongbiListArgs : IContractArgs
	{
		private String _patientCode;

		public String PatientCode
		{
			get { return this._patientCode; }
			set { this._patientCode = value; }
		}

		public NuroOUT0101U02GridGongbiListArgs() { }

		public NuroOUT0101U02GridGongbiListArgs(String patientCode)
		{
			this._patientCode = patientCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GridGongbiListRequest();
		}
	}
}