using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01CheckFkOcsArgs : IContractArgs
	{
		private String _fkOcs;

		public String FkOcs
		{
			get { return this._fkOcs; }
			set { this._fkOcs = value; }
		}

		public OcsoOCS1003P01CheckFkOcsArgs() { }

		public OcsoOCS1003P01CheckFkOcsArgs(String fkOcs)
		{
			this._fkOcs = fkOcs;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01CheckFkOcsRequest();
		}
	}
}