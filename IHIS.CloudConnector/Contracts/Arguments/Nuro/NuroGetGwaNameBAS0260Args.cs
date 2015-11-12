using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroGetGwaNameBAS0260Args : IContractArgs
	{
		private String _gwa;
		private String _date;

		public String Gwa
		{
			get { return this._gwa; }
			set { this._gwa = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public NuroGetGwaNameBAS0260Args() { }

		public NuroGetGwaNameBAS0260Args(String gwa, String date)
		{
			this._gwa = gwa;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroGetGwaNameBAS0260Request();
		}
	}
}