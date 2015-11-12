using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class OcsLoadInputControlArgs : IContractArgs
	{
		private String _inputControl;

		public String InputControl
		{
			get { return this._inputControl; }
			set { this._inputControl = value; }
		}

		public OcsLoadInputControlArgs() { }

		public OcsLoadInputControlArgs(String inputControl)
		{
			this._inputControl = inputControl;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsLoadInputControlRequest();
		}
	}
}