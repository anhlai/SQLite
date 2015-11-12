using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00NaewonDateArgs : IContractArgs
	{
		private String _naewonKey;

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public XRT0201U00NaewonDateArgs() { }

		public XRT0201U00NaewonDateArgs(String naewonKey)
		{
			this._naewonKey = naewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00NaewonDateRequest();
		}
	}
}