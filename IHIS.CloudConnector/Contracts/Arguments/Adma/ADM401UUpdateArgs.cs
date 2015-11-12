using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM401UUpdateArgs : IContractArgs
	{
		private Boolean _hasVersion;
		private String _asmVer;
		private String _asmName;

		public Boolean HasVersion
		{
			get { return this._hasVersion; }
			set { this._hasVersion = value; }
		}

		public String AsmVer
		{
			get { return this._asmVer; }
			set { this._asmVer = value; }
		}

		public String AsmName
		{
			get { return this._asmName; }
			set { this._asmName = value; }
		}

		public ADM401UUpdateArgs() { }

		public ADM401UUpdateArgs(Boolean hasVersion, String asmVer, String asmName)
		{
			this._hasVersion = hasVersion;
			this._asmVer = asmVer;
			this._asmName = asmName;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM401UUpdateRequest();
		}
	}
}