using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0301Q09IsDoctorArgs : IContractArgs
	{
		private String _doctor;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OCS0301Q09IsDoctorArgs() { }

		public OCS0301Q09IsDoctorArgs(String doctor)
		{
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0301Q09IsDoctorRequest();
		}
	}
}