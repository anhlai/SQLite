using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.System
{
	public class FormEnvironInfoMessageArgs : IContractArgs
	{
		private String _msgNum;

		public String MsgNum
		{
			get { return this._msgNum; }
			set { this._msgNum = value; }
		}

		public FormEnvironInfoMessageArgs() { }

		public FormEnvironInfoMessageArgs(String msgNum)
		{
			this._msgNum = msgNum;
		}

		public IExtensible GetRequestInstance()
		{
			return new FormEnvironInfoMessageRequest();
		}
	}
}