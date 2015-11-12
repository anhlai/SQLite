using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0304U00GetDoctorYaksokOpenIdArgs : IContractArgs
	{
		private String _doctor;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public OcsaOCS0304U00GetDoctorYaksokOpenIdArgs() { }

		public OcsaOCS0304U00GetDoctorYaksokOpenIdArgs(String doctor)
		{
			this._doctor = doctor;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0304U00GetDoctorYaksokOpenIdRequest();
		}
	}
}