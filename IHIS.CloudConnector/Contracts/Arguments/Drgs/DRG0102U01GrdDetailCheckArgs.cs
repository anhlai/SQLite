using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U01GrdDetailCheckArgs : IContractArgs
	{
		private String _code;
		private String _codeType;

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public DRG0102U01GrdDetailCheckArgs() { }

		public DRG0102U01GrdDetailCheckArgs(String code, String codeType)
		{
			this._code = code;
			this._codeType = codeType;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U01GrdDetailCheckRequest();
		}
	}
}