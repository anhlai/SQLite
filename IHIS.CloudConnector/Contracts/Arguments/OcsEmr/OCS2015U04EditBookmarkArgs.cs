using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U04EditBookmarkArgs : IContractArgs
	{
		private String _bookmarkText;
		private String _updId;
		private String _emrBookmarkId;

		public String BookmarkText
		{
			get { return this._bookmarkText; }
			set { this._bookmarkText = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public String EmrBookmarkId
		{
			get { return this._emrBookmarkId; }
			set { this._emrBookmarkId = value; }
		}

		public OCS2015U04EditBookmarkArgs() { }

		public OCS2015U04EditBookmarkArgs(String bookmarkText, String updId, String emrBookmarkId)
		{
			this._bookmarkText = bookmarkText;
			this._updId = updId;
			this._emrBookmarkId = emrBookmarkId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U04EditBookmarkRequest();
		}
	}
}