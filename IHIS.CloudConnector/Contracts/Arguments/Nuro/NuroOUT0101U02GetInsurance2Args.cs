using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuro
{
	public class NuroOUT0101U02GetInsurance2Args : IContractArgs
	{
		private String _find1;

		public String Find1
		{
			get { return this._find1; }
			set { this._find1 = value; }
		}

		public NuroOUT0101U02GetInsurance2Args() { }

		public NuroOUT0101U02GetInsurance2Args(String find1)
		{
			this._find1 = find1;
		}

		public IExtensible GetRequestInstance()
		{
			return new NuroOUT0101U02GetInsurance2Request();
		}
	}
}