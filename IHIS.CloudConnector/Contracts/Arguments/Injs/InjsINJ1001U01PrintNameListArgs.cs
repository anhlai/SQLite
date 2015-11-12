using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01PrintNameListArgs : IContractArgs
	{
		private String _ipAddr;

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public InjsINJ1001U01PrintNameListArgs() { }

		public InjsINJ1001U01PrintNameListArgs(String ipAddr)
		{
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01PrintNameListRequest();
		}
	}
}