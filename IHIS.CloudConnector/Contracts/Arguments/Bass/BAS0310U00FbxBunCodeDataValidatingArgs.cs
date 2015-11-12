using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00FbxBunCodeDataValidatingArgs : IContractArgs
	{
		private String _bunCode;
		private String _code;
		private String _colName;

		public String BunCode
		{
			get { return this._bunCode; }
			set { this._bunCode = value; }
		}

		public String Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public String ColName
		{
			get { return this._colName; }
			set { this._colName = value; }
		}

		public BAS0310U00FbxBunCodeDataValidatingArgs() { }

		public BAS0310U00FbxBunCodeDataValidatingArgs(String bunCode, String code, String colName)
		{
			this._bunCode = bunCode;
			this._code = code;
			this._colName = colName;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00FbxBunCodeDataValidatingRequest();
		}
	}
}