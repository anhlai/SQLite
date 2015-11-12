using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01BasLoadGwaNameArgs : IContractArgs
	{
		private String _gwa;
		private String _buseoYmd;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String BuseoYmd
		{
			get { return this._buseoYmd; }
			set { this._buseoYmd = value; }
		}

		public OcsoOCS1003P01BasLoadGwaNameArgs() { }

		public OcsoOCS1003P01BasLoadGwaNameArgs(String gwa, String buseoYmd)
		{
			this._gwa = gwa;
			this._buseoYmd = buseoYmd;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01BasLoadGwaNameRequest();
		}
	}
}