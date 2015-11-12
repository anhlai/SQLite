using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0131U00GetFwkCodeArgs : IContractArgs
	{
		private String _find1;

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public OCS0131U00GetFwkCodeArgs() { }

		public OCS0131U00GetFwkCodeArgs(String find1)
		{
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0131U00GetFwkCodeRequest();
		}
	}
}