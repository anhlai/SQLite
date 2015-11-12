using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM501UJapanEmptyListArgs : IContractArgs
	{
		private String _msgGubun;

		public String MsgGubun
		{
			get { return this._msgGubun; }
			set { this._msgGubun = value; }
		}

		public ADM501UJapanEmptyListArgs() { }

		public ADM501UJapanEmptyListArgs(String msgGubun)
		{
			this._msgGubun = msgGubun;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM501UJapanEmptyListRequest();
		}
	}
}