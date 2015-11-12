using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsLoadBunhoInfoArgs : IContractArgs
	{
		private String _naewonDate;
		private String _bunho;

		public String NaewonDate
		{
			get { return this._naewonDate; }
			set { this._naewonDate = value; }
		}

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public PrOcsLoadBunhoInfoArgs() { }

		public PrOcsLoadBunhoInfoArgs(String naewonDate, String bunho)
		{
			this._naewonDate = naewonDate;
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsLoadBunhoInfoRequest();
		}
	}
}