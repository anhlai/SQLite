using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocso
{
	public class OcsoOCS1003P01GetGroupKeyArgs : IContractArgs
	{
		private String _pkout1001;
		private String _codeType;

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public OcsoOCS1003P01GetGroupKeyArgs() { }

		public OcsoOCS1003P01GetGroupKeyArgs(String pkout1001, String codeType)
		{
			this._pkout1001 = pkout1001;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new OcsoOCS1003P01GetGroupKeyRequest();
		}
	}
}