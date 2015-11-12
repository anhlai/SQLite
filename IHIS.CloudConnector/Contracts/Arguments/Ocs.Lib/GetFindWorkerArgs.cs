using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetFindWorkerRequestInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetFindWorkerRequestInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetFindWorkerArgs : IContractArgs
	{
		private GetFindWorkerRequestInfo _info1;

		public GetFindWorkerRequestInfo Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public GetFindWorkerArgs() { }

		public GetFindWorkerArgs(GetFindWorkerRequestInfo info1)
		{
			this._info1 = info1;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetFindWorkerRequest();
		}
	}
}