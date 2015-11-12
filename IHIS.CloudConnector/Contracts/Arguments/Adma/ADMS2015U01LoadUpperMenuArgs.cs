using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADMS2015U01LoadUpperMenuArgs : IContractArgs
	{
		private String _sysId;
		private String _hospCode;

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public ADMS2015U01LoadUpperMenuArgs() { }

		public ADMS2015U01LoadUpperMenuArgs(String sysId, String hospCode)
		{
			this._sysId = sysId;
			this._hospCode = hospCode;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADMS2015U01LoadUpperMenuRequest();
		}
	}
}