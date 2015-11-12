using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00PrOcsoChkResultMsgArgs : IContractArgs
	{
		private String _ocskey;
		private String _userId;

		public String Ocskey
		{
			get { return this._ocskey; }
			set { this._ocskey = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL3020U00PrOcsoChkResultMsgArgs() { }

		public CPL3020U00PrOcsoChkResultMsgArgs(String ocskey, String userId)
		{
			this._ocskey = ocskey;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00PrOcsoChkResultMsgRequest();
		}
	}
}