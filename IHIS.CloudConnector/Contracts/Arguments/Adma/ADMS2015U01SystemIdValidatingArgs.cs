using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADMS2015U01SystemIdValidatingArgs : IContractArgs
	{
		private String _hospCode;
		private String _sysId;

		public String HospCode
		{
			get { return this._hospCode; }
			set { this._hospCode = value; }
		}

		public String SysId
		{
			get { return this._sysId; }
			set { this._sysId = value; }
		}

		public ADMS2015U01SystemIdValidatingArgs() { }

		public ADMS2015U01SystemIdValidatingArgs(String hospCode, String sysId)
		{
			this._hospCode = hospCode;
			this._sysId = sysId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADMS2015U01SystemIdValidatingRequest();
		}
	}
}