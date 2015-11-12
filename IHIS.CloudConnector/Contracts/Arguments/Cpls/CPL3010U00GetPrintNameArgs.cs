using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00GetPrintNameArgs : IContractArgs
	{
		private String _ipAddr;

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public CPL3010U00GetPrintNameArgs() { }

		public CPL3010U00GetPrintNameArgs(String ipAddr)
		{
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00GetPrintNameRequest();
		}
	}
}