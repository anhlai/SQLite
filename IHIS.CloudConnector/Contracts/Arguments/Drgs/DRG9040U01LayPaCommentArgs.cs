using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG9040U01LayPaCommentArgs : IContractArgs
	{
		private String _bunho;

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public DRG9040U01LayPaCommentArgs() { }

		public DRG9040U01LayPaCommentArgs(String bunho)
		{
			this._bunho = bunho;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG9040U01LayPaCommentRequest();
		}
	}
}