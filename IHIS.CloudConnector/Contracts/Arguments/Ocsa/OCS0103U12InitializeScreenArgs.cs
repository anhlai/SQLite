using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using LoadColumnCodeNameInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.LoadColumnCodeNameInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U12InitializeScreenArgs : IContractArgs
	{
		private LoadColumnCodeNameInfo _code;

		public LoadColumnCodeNameInfo Code
		{
			get { return this._code; }
			set { this._code = value; }
		}

		public OCS0103U12InitializeScreenArgs() { }

		public OCS0103U12InitializeScreenArgs(LoadColumnCodeNameInfo code)
		{
			this._code = code;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U12InitializeScreenRequest();
		}
	}
}