using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Xrts
{
	public class XRT0201U00OcsCommonArgs : IContractArgs
	{
		private String _userId;

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public XRT0201U00OcsCommonArgs() { }

		public XRT0201U00OcsCommonArgs(String userId)
		{
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new XRT0201U00OcsCommonRequest();
		}
	}
}