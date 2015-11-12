using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0101U00MakeValSerViceArgs : IContractArgs
	{
		private String _aCtlName;
		private String _codeType;
		private String _code;

		public String ACtlName
		{
			get { return this._aCtlName; }
			set { this._aCtlName = value; }
		}

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

		public CPL0101U00MakeValSerViceArgs() { }

		public CPL0101U00MakeValSerViceArgs(String aCtlName, String codeType, String code)
		{
			this._aCtlName = aCtlName;
			this._codeType = codeType;
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0101U00MakeValSerViceRequest();
		}
	}
}