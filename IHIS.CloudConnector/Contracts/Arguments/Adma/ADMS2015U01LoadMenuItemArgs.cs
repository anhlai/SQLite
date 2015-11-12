using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADMS2015U01LoadMenuItemArgs : IContractArgs
	{
		private String _sysId;
		private String _upprMenu;
		private String _hospCode;

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public String UpprMenu
		{
			get { return this._upprMenu; }
			set { this._upprMenu = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public ADMS2015U01LoadMenuItemArgs() { }

		public ADMS2015U01LoadMenuItemArgs(String sysId, String upprMenu, String hospCode)
		{
			this._sysId = sysId;
			this._upprMenu = upprMenu;
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADMS2015U01LoadMenuItemRequest();
		}
	}
}