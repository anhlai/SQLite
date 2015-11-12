using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U17MakeJaeryoGubunTabArgs : IContractArgs
	{
		private String _inputTab;

		public String InputTab
		{
			get { return this._inputTab; }
			set { this._inputTab = value; }
		}

		public OCS0103U17MakeJaeryoGubunTabArgs() { }

		public OCS0103U17MakeJaeryoGubunTabArgs(String inputTab)
		{
			this._inputTab = inputTab;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U17MakeJaeryoGubunTabRequest();
		}
	}
}