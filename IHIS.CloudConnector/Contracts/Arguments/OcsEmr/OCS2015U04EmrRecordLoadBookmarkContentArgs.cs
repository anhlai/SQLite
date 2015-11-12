using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U04EmrRecordLoadBookmarkContentArgs : IContractArgs
	{
		private String _emrRecordId;

		public String EmrRecordId
		{
			get { return this._emrRecordId; }
			set { this._emrRecordId = value; }
		}

		public OCS2015U04EmrRecordLoadBookmarkContentArgs() { }

		public OCS2015U04EmrRecordLoadBookmarkContentArgs(String emrRecordId)
		{
			this._emrRecordId = emrRecordId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U04EmrRecordLoadBookmarkContentRequest();
		}
	}
}