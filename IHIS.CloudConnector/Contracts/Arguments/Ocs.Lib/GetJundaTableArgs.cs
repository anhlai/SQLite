using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetJundaTableRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetJundaTableRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetJundaTableArgs : IContractArgs
	{
		private GetJundaTableRequestInfo _info1;

		public GetJundaTableRequestInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public GetJundaTableArgs() { }

		public GetJundaTableArgs(GetJundaTableRequestInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetJundaTableRequest();
		}
	}
}