using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OcsaOCS0204U00FindWorkerListArgs : IContractArgs
	{
		private String _find1;

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public OcsaOCS0204U00FindWorkerListArgs() { }

		public OcsaOCS0204U00FindWorkerListArgs(String find1)
		{
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsaOCS0204U00FindWorkerListRequest();
		}
	}
}