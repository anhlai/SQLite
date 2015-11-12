using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U06EmrRecordUpdateMetaArgs : IContractArgs
	{
		private String _fRecordId;
		private String _fMeta;

		public String FRecordId
		{
			get { return this._fRecordId; }
			set { this._fRecordId = value; }
		}

		public String FMeta
		{
			get { return this._fMeta; }
			set { this._fMeta = value; }
		}

		public OCS2015U06EmrRecordUpdateMetaArgs() { }

		public OCS2015U06EmrRecordUpdateMetaArgs(String fRecordId, String fMeta)
		{
			this._fRecordId = fRecordId;
			this._fMeta = fMeta;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U06EmrRecordUpdateMetaRequest();
		}
	}
}