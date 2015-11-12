using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OcsLoadVisibleControlArgs : IContractArgs
	{
		private String _inputTab;

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OcsLoadVisibleControlArgs() { }

		public OcsLoadVisibleControlArgs(String inputTab)
		{
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsLoadVisibleControlRequest();
		}
	}
}