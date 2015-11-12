using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U44EmrHistoricRecordUpdateArgs : IContractArgs
	{
		private String _recordId;
		private String _updId;
		private String _content;
		private String _metadata;
		private String _recordLog;
		private String _emailFlg;

		public String RecordId
		{
			get { return this._recordId; }
			set { this._recordId = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public String Content
		{
			get { return this._content; }
			set { this._content = value; }
		}

		public String Metadata
		{
			get { return this._metadata; }
			set { this._metadata = value; }
		}

		public String RecordLog
		{
			get { return this._recordLog; }
			set { this._recordLog = value; }
		}

		public String EmailFlg
		{
			get { return this._emailFlg; }
			set { this._emailFlg = value; }
		}

		public OCS2015U44EmrHistoricRecordUpdateArgs() { }

		public OCS2015U44EmrHistoricRecordUpdateArgs(String recordId, String updId, String content, String metadata, String recordLog, String emailFlg)
		{
			this._recordId = recordId;
			this._updId = updId;
			this._content = content;
			this._metadata = metadata;
			this._recordLog = recordLog;
			this._emailFlg = emailFlg;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U44EmrHistoricRecordUpdateRequest();
		}
	}
}