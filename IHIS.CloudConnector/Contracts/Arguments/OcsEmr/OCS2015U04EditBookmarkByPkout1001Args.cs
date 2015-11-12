using System;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;

namespace IHIS.CloudConnector.Contracts.Arguments.OcsEmr
{
	public class OCS2015U04EditBookmarkByPkout1001Args : IContractArgs
	{
		private String _bookmarkText;
		private String _updId;
		private String _emrBookmarkId;
		private String _pkout1001;

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

		public String Pkout1001
		{
			get { return this._pkout1001; }
			set { this._pkout1001 = value; }
		}

		public OCS2015U04EditBookmarkByPkout1001Args() { }

		public OCS2015U04EditBookmarkByPkout1001Args(String bookmarkText, String updId, String emrBookmarkId, String pkout1001)
		{
			this._bookmarkText = bookmarkText;
			this._updId = updId;
			this._emrBookmarkId = emrBookmarkId;
			this._pkout1001 = pkout1001;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS2015U04EditBookmarkByPkout1001Request();
		}
	}
}