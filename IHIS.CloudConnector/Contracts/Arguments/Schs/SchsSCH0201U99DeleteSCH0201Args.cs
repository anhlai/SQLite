using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Schs
{
	public class SchsSCH0201U99DeleteSCH0201Args : IContractArgs
	{
		private String _fPksch;

		public String FPksch
		{
			get { return this._fPksch; }
			set { this._fPksch = value; }
		}

		public SchsSCH0201U99DeleteSCH0201Args() { }

		public SchsSCH0201U99DeleteSCH0201Args(String fPksch)
		{
			this._fPksch = fPksch;
		}

		public IExtensible GetRequestInstance()
		{
			return new SchsSCH0201U99DeleteSCH0201Request();
		}
	}
}