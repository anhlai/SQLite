using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadColumnCodeNameInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadColumnCodeNameInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12LoadColumnNameArgs : IContractArgs
	{
		private LoadColumnCodeNameInfo _code;

		public LoadColumnCodeNameInfo Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OCS0103U12LoadColumnNameArgs() { }

		public OCS0103U12LoadColumnNameArgs(LoadColumnCodeNameInfo code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12LoadColumnNameRequest();
		}
	}
}