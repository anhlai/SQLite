using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12IsUpdateCheckSelectArgs : IContractArgs
	{
		private String _pkocs2003;

		public String Pkocs2003
		{
			get { return this._pkocs2003; }
			set { this._pkocs2003 = value; }
		}

		public OCS0103U12IsUpdateCheckSelectArgs() { }

		public OCS0103U12IsUpdateCheckSelectArgs(String pkocs2003)
		{
			this._pkocs2003 = pkocs2003;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12IsUpdateCheckSelectRequest();
		}
	}
}