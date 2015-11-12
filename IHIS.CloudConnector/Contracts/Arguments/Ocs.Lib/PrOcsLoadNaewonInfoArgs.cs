using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class PrOcsLoadNaewonInfoArgs : IContractArgs
	{
		private String _naewonKey;

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public PrOcsLoadNaewonInfoArgs() { }

		public PrOcsLoadNaewonInfoArgs(String naewonKey)
		{
			this._naewonKey = naewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new PrOcsLoadNaewonInfoRequest();
		}
	}
}