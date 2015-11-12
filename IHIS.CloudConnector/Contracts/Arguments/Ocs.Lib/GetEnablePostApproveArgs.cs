using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetEnablePostApproveInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetEnablePostApproveInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetEnablePostApproveArgs : IContractArgs
	{
		private GetEnablePostApproveInfo _aproveInfo;

		public GetEnablePostApproveInfo AproveInfo
		{
			get { return this._aproveInfo; }
			set { this._aproveInfo = value; }
		}

		public GetEnablePostApproveArgs() { }

		public GetEnablePostApproveArgs(GetEnablePostApproveInfo aproveInfo)
		{
			this._aproveInfo = aproveInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetEnablePostApproveRequest();
		}
	}
}