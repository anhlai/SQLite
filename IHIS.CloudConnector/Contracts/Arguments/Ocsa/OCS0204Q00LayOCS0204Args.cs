using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0204Q00LayOCS0204Args : IContractArgs
	{
		private String _memb;

		public String Memb
		{
			get { return this._memb; }
			set { this._memb = value; }
		}

		public OCS0204Q00LayOCS0204Args() { }

		public OCS0204Q00LayOCS0204Args(String memb)
		{
			this._memb = memb;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0204Q00LayOCS0204Request();
		}
	}
}