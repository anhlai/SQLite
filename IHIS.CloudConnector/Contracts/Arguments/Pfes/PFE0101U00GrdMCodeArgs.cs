using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Pfes
{
	public class PFE0101U00GrdMCodeArgs : IContractArgs
	{
		private String _codeType;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public PFE0101U00GrdMCodeArgs() { }

		public PFE0101U00GrdMCodeArgs(String codeType)
		{
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new PFE0101U00GrdMCodeRequest();
		}
	}
}