using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U09GetNodeTagsForContextArgs : IContractArgs
	{
		private String _fParentTagCode;
		private String _fUserId;

		public String FParentTagCode
		{
			get { return this._fParentTagCode; }
			set { this._fParentTagCode = value; }
		}

		public String FUserId
		{
			get { return this._fUserId; }
			set { this._fUserId = value; }
		}

		public OCS2015U09GetNodeTagsForContextArgs() { }

		public OCS2015U09GetNodeTagsForContextArgs(String fParentTagCode, String fUserId)
		{
			this._fParentTagCode = fParentTagCode;
			this._fUserId = fUserId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U09GetNodeTagsForContextRequest();
		}
	}
}