using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0304U00GrdOCS0306Args : IContractArgs
	{
		private String _doctor;
		private String _yaksokDirectCode;

		public String Doctor
		{
			get { return this._doctor; }
			set { this._doctor = value; }
		}

		public String YaksokDirectCode
		{
			get { return this._yaksokDirectCode; }
			set { this._yaksokDirectCode = value; }
		}

		public OCS0304U00GrdOCS0306Args() { }

		public OCS0304U00GrdOCS0306Args(String doctor, String yaksokDirectCode)
		{
			this._doctor = doctor;
			this._yaksokDirectCode = yaksokDirectCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0304U00GrdOCS0306Request();
		}
	}
}