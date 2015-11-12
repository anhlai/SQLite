using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroChkGetBunhoBySujinArgs : IContractArgs
	{
		private String _naewonDate;
		private String _sujinNo;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String SujinNo
		{
			get { return this._sujinNo; }
			set { this._sujinNo = value; }
		}

		public NuroChkGetBunhoBySujinArgs() { }

		public NuroChkGetBunhoBySujinArgs(String naewonDate, String sujinNo)
		{
			this._naewonDate = naewonDate;
			this._sujinNo = sujinNo;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroChkGetBunhoBySujinRequest();
		}
	}
}