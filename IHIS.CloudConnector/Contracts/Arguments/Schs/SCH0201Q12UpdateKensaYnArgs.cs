using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SCH0201Q12UpdateKensaYnArgs : IContractArgs
	{
		private String _pkout1001;

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public SCH0201Q12UpdateKensaYnArgs() { }

		public SCH0201Q12UpdateKensaYnArgs(String pkout1001)
		{
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new SCH0201Q12UpdateKensaYnRequest();
		}
	}
}