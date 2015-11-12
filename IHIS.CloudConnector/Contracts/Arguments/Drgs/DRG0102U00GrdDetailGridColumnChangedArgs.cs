using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U00GrdDetailGridColumnChangedArgs : IContractArgs
	{
		private String _codeType;
		private String _code;

		public String CodeType
		{
			get { return this._codeType; }
			set { this._codeType = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public DRG0102U00GrdDetailGridColumnChangedArgs() { }

		public DRG0102U00GrdDetailGridColumnChangedArgs(String codeType, String code)
		{
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U00GrdDetailGridColumnChangedRequest();
		}
	}
}