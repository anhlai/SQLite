using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1017U00GrdNUR1017Args : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public NUR1017U00GrdNUR1017Args() { }

		public NUR1017U00GrdNUR1017Args(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1017U00GrdNUR1017Request();
		}
	}
}