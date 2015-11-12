using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201Q04ReserTimeListArgs : IContractArgs
	{
		private String _ipAddr;

		public String IpAddr
		{
			get { return this._ipAddr; }
			set { this._ipAddr = value; }
		}

		public SchsSCH0201Q04ReserTimeListArgs() { }

		public SchsSCH0201Q04ReserTimeListArgs(String ipAddr)
		{
			this._ipAddr = ipAddr;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201Q04ReserTimeListRequest();
		}
	}
}