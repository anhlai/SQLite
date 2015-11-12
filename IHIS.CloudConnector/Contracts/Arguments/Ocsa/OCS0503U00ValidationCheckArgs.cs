using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0503U00ValidationCheckArgs : IContractArgs
	{
		private String _fkout1001;

		public String Fkout1001
		{
			get { return this._fkout1001; }
			set { this._fkout1001 = value; }
		}

		public OCS0503U00ValidationCheckArgs() { }

		public OCS0503U00ValidationCheckArgs(String fkout1001)
		{
			this._fkout1001 = fkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0503U00ValidationCheckRequest();
		}
	}
}