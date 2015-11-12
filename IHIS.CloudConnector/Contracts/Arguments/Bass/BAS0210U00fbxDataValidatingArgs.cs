using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00fbxDataValidatingArgs : IContractArgs
	{
		private String _codeType;
		private String _code;
		private String _controlName;

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

		public String ControlName
		{
			get { return this._controlName; }
			set { this._controlName = value; }
		}

		public BAS0210U00fbxDataValidatingArgs() { }

		public BAS0210U00fbxDataValidatingArgs(String codeType, String code, String controlName)
		{
			this._codeType = codeType;
			this._code = code;
			this._controlName = controlName;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00fbxDataValidatingRequest();
		}
	}
}