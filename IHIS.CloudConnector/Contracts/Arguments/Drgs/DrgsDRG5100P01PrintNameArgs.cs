using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DrgsDRG5100P01PrintNameArgs : IContractArgs
	{
		private String _ipAddr;

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public DrgsDRG5100P01PrintNameArgs() { }

		public DrgsDRG5100P01PrintNameArgs(String ipAddr)
		{
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new DrgsDRG5100P01PrintNameRequest();
		}
	}
}