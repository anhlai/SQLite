using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Outs
{
	public class OUT0106U00GridListArgs : IContractArgs
	{
		private String _bunho;
		private String _naewonDate;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public OUT0106U00GridListArgs() { }

		public OUT0106U00GridListArgs(String bunho, String naewonDate)
		{
			this._bunho = bunho;
			this._naewonDate = naewonDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OUT0106U00GridListRequest();
		}
	}
}