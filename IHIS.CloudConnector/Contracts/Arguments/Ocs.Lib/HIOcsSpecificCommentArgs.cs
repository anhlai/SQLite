using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocs.Lib
{
	public class HIOcsSpecificCommentArgs : IContractArgs
	{
		private String _specificComment;

		public String SpecificComment
		{
			get { return this._specificComment; }
			set { this._specificComment = value; }
		}

		public HIOcsSpecificCommentArgs() { }

		public HIOcsSpecificCommentArgs(String specificComment)
		{
			this._specificComment = specificComment;
		}

		public IExtensible GetRequestInstance()
		{
			return new HIOcsSpecificCommentRequest();
		}
	}
}