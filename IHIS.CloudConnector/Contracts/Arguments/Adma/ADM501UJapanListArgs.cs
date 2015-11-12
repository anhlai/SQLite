using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM501UJapanListArgs : IContractArgs
	{
		private String _msgGubun;
		private String _searchMsg;

		public String MsgGubun
		{
			get { return this._msgGubun; }
			set { this._msgGubun = value; }
		}

		public String SearchMsg
		{
			get { return this._searchMsg; }
			set { this._searchMsg = value; }
		}

		public ADM501UJapanListArgs() { }

		public ADM501UJapanListArgs(String msgGubun, String searchMsg)
		{
			this._msgGubun = msgGubun;
			this._searchMsg = searchMsg;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM501UJapanListRequest();
		}
	}
}