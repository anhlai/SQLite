using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM401UInsertArgs : IContractArgs
	{
		private Boolean _hasVersion;
		private String _asmName;
		private String _asmType;
		private String _grpId;
		private String _sysId;
		private String _asmVer;
		private String _asmPath;
		private String _userId;

		public Boolean HasVersion
		{
			get { return this._hasVersion; }
			set { this._hasVersion = value; }
		}

		public String AsmName
		{
			get { return this._asmName; }
			set { this._asmName = value; }
		}

		public String AsmType
		{
			get { return this._asmType; }
			set { this._asmType = value; }
		}

		public String GrpId
		{
			get { return this._grpId; }
			set { this._grpId = value; }
		}

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public String AsmVer
		{
			get { return this._asmVer; }
			set { this._asmVer = value; }
		}

		public String AsmPath
		{
			get { return this._asmPath; }
			set { this._asmPath = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public ADM401UInsertArgs() { }

		public ADM401UInsertArgs(Boolean hasVersion, String asmName, String asmType, String grpId, String sysId, String asmVer, String asmPath, String userId)
		{
			this._hasVersion = hasVersion;
			this._asmName = asmName;
			this._asmType = asmType;
			this._grpId = grpId;
			this._sysId = sysId;
			this._asmVer = asmVer;
			this._asmPath = asmPath;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM401UInsertRequest();
		}
	}
}