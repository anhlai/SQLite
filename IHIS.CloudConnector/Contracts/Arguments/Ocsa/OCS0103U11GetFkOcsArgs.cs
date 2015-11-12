using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U11GetFkocsArgs : IContractArgs
	{
		private String _pkocskey;

		public String Pkocskey
		{
			get { return this._pkocskey; }
			set { this._pkocskey = value; }
		}

		public OCS0103U11GetFkocsArgs() { }

		public OCS0103U11GetFkocsArgs(String pkocskey)
		{
			this._pkocskey = pkocskey;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U11GetFkocsRequest();
		}
	}
}