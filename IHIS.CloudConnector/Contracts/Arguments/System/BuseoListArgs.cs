using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class BuseoListArgs : IContractArgs
	{
		private String _buseoGubun;

		public String BuseoGubun
		{
			get { return this._buseoGubun; }
			set { this._buseoGubun = value; }
		}

		public BuseoListArgs() { }

		public BuseoListArgs(String buseoGubun)
		{
			this._buseoGubun = buseoGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new BuseoListRequest();
		}
	}
}