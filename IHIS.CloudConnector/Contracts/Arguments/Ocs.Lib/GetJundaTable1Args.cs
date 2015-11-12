using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetJundaTableRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetJundaTableRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetJundaTable1Args : IContractArgs
	{
		private GetJundaTableRequestInfo _info1;

		public GetJundaTableRequestInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public GetJundaTable1Args() { }

		public GetJundaTable1Args(GetJundaTableRequestInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetJundaTable1Request();
		}
	}
}