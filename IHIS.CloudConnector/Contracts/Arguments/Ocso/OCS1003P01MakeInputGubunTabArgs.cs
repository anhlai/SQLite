using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OCS1003P01MakeInputGubunTabArgs : IContractArgs
	{
		private String _code;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OCS1003P01MakeInputGubunTabArgs() { }

		public OCS1003P01MakeInputGubunTabArgs(String code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS1003P01MakeInputGubunTabRequest();
		}
	}
}