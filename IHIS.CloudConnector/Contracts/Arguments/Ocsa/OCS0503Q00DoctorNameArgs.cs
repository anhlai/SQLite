using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503Q00DoctorNameArgs : IContractArgs
	{
		private String _gwa;
		private String _doctorCode;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String DoctorCode
		{
			get { return this._doctorCode; }
			set { this._doctorCode = value; }
		}

		public OCS0503Q00DoctorNameArgs() { }

		public OCS0503Q00DoctorNameArgs(String gwa, String doctorCode)
		{
			this._gwa = gwa;
			this._doctorCode = doctorCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503Q00DoctorNameRequest();
		}
	}
}