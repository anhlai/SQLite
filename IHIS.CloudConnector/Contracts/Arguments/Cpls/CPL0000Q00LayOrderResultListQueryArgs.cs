using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00LayOrderResultListQueryArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public CPL0000Q00LayOrderResultListQueryArgs() { }

		public CPL0000Q00LayOrderResultListQueryArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00LayOrderResultListQueryRequest();
		}
	}
}