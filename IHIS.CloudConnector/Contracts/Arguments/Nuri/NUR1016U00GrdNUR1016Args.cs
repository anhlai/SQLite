using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1016U00GrdNUR1016Args : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public NUR1016U00GrdNUR1016Args() { }

		public NUR1016U00GrdNUR1016Args(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1016U00GrdNUR1016Request();
		}
	}
}