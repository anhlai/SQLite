using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0000Q00LayOrderJubsuListQueryArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public CPL0000Q00LayOrderJubsuListQueryArgs() { }

		public CPL0000Q00LayOrderJubsuListQueryArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0000Q00LayOrderJubsuListQueryRequest();
		}
	}
}