using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01CheckYArgs : IContractArgs
	{
		private String _naewonKey;

		public String NaewonKey
		{
			get { return this._naewonKey; }
			set { this._naewonKey = value; }
		}

		public OcsoOCS1003P01CheckYArgs() { }

		public OcsoOCS1003P01CheckYArgs(String naewonKey)
		{
			this._naewonKey = naewonKey;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01CheckYRequest();
		}
	}
}