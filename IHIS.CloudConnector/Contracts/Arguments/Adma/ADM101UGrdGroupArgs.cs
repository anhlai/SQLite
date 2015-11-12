using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM101UGrdGroupArgs : IContractArgs
	{
		private String _grpId;
		private String _grpNm;

		public String GrpId
		{
			get { return this._grpId; }
			set { this._grpId = value; }
		}

		public String GrpNm
		{
			get { return this._grpNm; }
			set { this._grpNm = value; }
		}

		public ADM101UGrdGroupArgs() { }

		public ADM101UGrdGroupArgs(String grpId, String grpNm)
		{
			this._grpId = grpId;
			this._grpNm = grpNm;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM101UGrdGroupRequest();
		}
	}
}