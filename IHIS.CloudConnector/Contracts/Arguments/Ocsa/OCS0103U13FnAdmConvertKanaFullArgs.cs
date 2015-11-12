using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U13FnAdmConvertKanaFullArgs : IContractArgs
	{
		private String _searchWord;

		public String SearchWord
		{
			get { return this._searchWord; }
			set { this._searchWord = value; }
		}

		public OCS0103U13FnAdmConvertKanaFullArgs() { }

		public OCS0103U13FnAdmConvertKanaFullArgs(String searchWord)
		{
			this._searchWord = searchWord;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U13FnAdmConvertKanaFullRequest();
		}
	}
}