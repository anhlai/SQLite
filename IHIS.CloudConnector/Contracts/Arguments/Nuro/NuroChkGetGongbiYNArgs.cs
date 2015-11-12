using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroChkGetGongbiYNArgs : IContractArgs
	{
		private String _gubun;
		private String _date;

		public String Gubun
		{
			get { return this._gubun; }
			set { this._gubun = value; }
		}

		public String Date
		{
			get { return this._date; }
			set { this._date = value; }
		}

		public NuroChkGetGongbiYNArgs() { }

		public NuroChkGetGongbiYNArgs(String gubun, String date)
		{
			this._gubun = gubun;
			this._date = date;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroChkGetGongbiYNRequest();
		}
	}
}