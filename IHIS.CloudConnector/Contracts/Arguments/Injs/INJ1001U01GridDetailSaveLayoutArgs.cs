using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using InjsINJ1001U01DetailListItemInfo = IHIS.CloudConnector.Contracts.Models.Injs.InjsINJ1001U01DetailListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Injs
{
	public class INJ1001U01GridDetailSaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private String _updId;
		private List<InjsINJ1001U01DetailListItemInfo> _itemInfo = new List<InjsINJ1001U01DetailListItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public String UpdId
		{
			get { return this._updId; }
			set { this._updId = value; }
		}

		public List<InjsINJ1001U01DetailListItemInfo> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public INJ1001U01GridDetailSaveLayoutArgs() { }

		public INJ1001U01GridDetailSaveLayoutArgs(String userId, String updId, List<InjsINJ1001U01DetailListItemInfo> itemInfo)
		{
			this._userId = userId;
			this._updId = updId;
			this._itemInfo = itemInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new INJ1001U01GridDetailSaveLayoutRequest();
		}
	}
}