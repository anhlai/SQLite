using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL3020U00GrdNoteUpdateInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3020U00GrdNoteUpdateInfo;
using CPL3020U00GrdResultListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3020U00GrdResultListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3020U00SavePerformerArgs : IContractArgs
	{
		private List<CPL3020U00GrdResultListItemInfo> _grdResultItem = new List<CPL3020U00GrdResultListItemInfo>();
		private List<CPL3020U00GrdNoteUpdateInfo> _grdNoteUpdateItem = new List<CPL3020U00GrdNoteUpdateInfo>();
		private String _userId;

		public List<CPL3020U00GrdResultListItemInfo> GrdResultItem
		{
			get { return this._grdResultItem; }
			set { this._grdResultItem = value; }
		}

		public List<CPL3020U00GrdNoteUpdateInfo> GrdNoteUpdateItem
		{
			get { return this._grdNoteUpdateItem; }
			set { this._grdNoteUpdateItem = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL3020U00SavePerformerArgs() { }

		public CPL3020U00SavePerformerArgs(List<CPL3020U00GrdResultListItemInfo> grdResultItem, List<CPL3020U00GrdNoteUpdateInfo> grdNoteUpdateItem, String userId)
		{
			this._grdResultItem = grdResultItem;
			this._grdNoteUpdateItem = grdNoteUpdateItem;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3020U00SavePerformerRequest();
		}
	}
}