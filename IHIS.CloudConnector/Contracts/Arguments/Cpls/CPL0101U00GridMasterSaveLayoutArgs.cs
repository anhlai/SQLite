using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL0101U00InitListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL0101U00InitListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL0101U00GridMasterSaveLayoutArgs : IContractArgs
	{
		private List<CPL0101U00InitListItemInfo> _itemInfo = new List<CPL0101U00InitListItemInfo>();
		private String _userId;

		public List<CPL0101U00InitListItemInfo> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL0101U00GridMasterSaveLayoutArgs() { }

		public CPL0101U00GridMasterSaveLayoutArgs(List<CPL0101U00InitListItemInfo> itemInfo, String userId)
		{
			this._itemInfo = itemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL0101U00GridMasterSaveLayoutRequest();
		}
	}
}