using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OcsLoadInputTabArgs : IContractArgs
	{
		private String _inputTab;

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OcsLoadInputTabArgs() { }

		public OcsLoadInputTabArgs(String inputTab)
		{
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsLoadInputTabRequest();
		}
	}
}