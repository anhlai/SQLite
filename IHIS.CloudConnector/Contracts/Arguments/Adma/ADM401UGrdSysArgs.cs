using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM401UGrdSysArgs : IContractArgs
	{
		private String _grpId;

		public String GrpId
		{
			get { return this._grpId; }
			set { this._grpId = value; }
		}

		public ADM401UGrdSysArgs() { }

		public ADM401UGrdSysArgs(String grpId)
		{
			this._grpId = grpId;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM401UGrdSysRequest();
		}
	}
}