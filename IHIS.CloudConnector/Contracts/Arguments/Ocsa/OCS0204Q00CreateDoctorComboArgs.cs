using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0204Q00CreateDoctorComboArgs : IContractArgs
	{
		private String _gwa;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public OCS0204Q00CreateDoctorComboArgs() { }

		public OCS0204Q00CreateDoctorComboArgs(String gwa)
		{
			this._gwa = gwa;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0204Q00CreateDoctorComboRequest();
		}
	}
}