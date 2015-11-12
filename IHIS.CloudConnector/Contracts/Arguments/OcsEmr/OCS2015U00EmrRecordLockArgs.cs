using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U00EmrRecordLockArgs : IContractArgs
	{
		private String _recordId;
		private String _updId;
		private String _screenId;

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

		public String ScreenId
		{
			get { return this._screenId; }
			set { this._screenId = value; }
		}

		public OCS2015U00EmrRecordLockArgs() { }

		public OCS2015U00EmrRecordLockArgs(String recordId, String updId, String screenId)
		{
			this._recordId = recordId;
			this._updId = updId;
			this._screenId = screenId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U00EmrRecordLockRequest();
		}
	}
}