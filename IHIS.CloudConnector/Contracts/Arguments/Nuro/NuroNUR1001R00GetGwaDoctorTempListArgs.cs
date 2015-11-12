using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroNUR1001R00GetGwaDoctorTempListArgs : IContractArgs
	{
		private String _gwa;
		private String _month;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Month
		{
			get { return this._month; }
			set { this._month = value; }
		}

		public NuroNUR1001R00GetGwaDoctorTempListArgs() { }

		public NuroNUR1001R00GetGwaDoctorTempListArgs(String gwa, String month)
		{
			this._gwa = gwa;
			this._month = month;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroNUR1001R00GetGwaDoctorTempListRequest();
		}
	}
}