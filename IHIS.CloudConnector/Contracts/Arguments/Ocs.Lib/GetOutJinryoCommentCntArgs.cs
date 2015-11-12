using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using GetOutJinryoCommentCntInfo = IHIS.CloudConnector.Contracts.Models.Ocs.Lib.GetOutJinryoCommentCntInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class GetOutJinryoCommentCntArgs : IContractArgs
	{
		private GetOutJinryoCommentCntInfo _jinryoCommentCntInfo;

		public GetOutJinryoCommentCntInfo JinryoCommentCntInfo
		{
			get { return this._jinryoCommentCntInfo; }
			set { this._jinryoCommentCntInfo = value; }
		}

		public GetOutJinryoCommentCntArgs() { }

		public GetOutJinryoCommentCntArgs(GetOutJinryoCommentCntInfo jinryoCommentCntInfo)
		{
			this._jinryoCommentCntInfo = jinryoCommentCntInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new GetOutJinryoCommentCntRequest();
		}
	}
}