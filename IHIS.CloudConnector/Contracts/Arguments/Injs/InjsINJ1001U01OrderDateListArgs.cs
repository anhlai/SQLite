using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class InjsINJ1001U01OrderDateListArgs : IContractArgs
	{
		private String _pkinj1002;

		public String Pkinj1002
		{
			get { return this._pkinj1002; }
			set { this._pkinj1002 = value; }
		}

		public InjsINJ1001U01OrderDateListArgs() { }

		public InjsINJ1001U01OrderDateListArgs(String pkinj1002)
		{
			this._pkinj1002 = pkinj1002;
		}

		public IExtensible GetRequestInstance()
		{
			return new InjsINJ1001U01OrderDateListRequest();
		}
	}
}