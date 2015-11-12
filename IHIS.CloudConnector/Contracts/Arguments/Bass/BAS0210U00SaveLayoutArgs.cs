using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using BAS0210U00grdBAS0210ItemInfo = IHIS.CloudConnector.Contracts.Models.Bass.BAS0210U00grdBAS0210ItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0210U00SaveLayoutArgs : IContractArgs
	{
		private List<BAS0210U00grdBAS0210ItemInfo> _itemInfo = new List<BAS0210U00grdBAS0210ItemInfo>();
		private String _userId;

		public List<BAS0210U00grdBAS0210ItemInfo> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public BAS0210U00SaveLayoutArgs() { }

		public BAS0210U00SaveLayoutArgs(List<BAS0210U00grdBAS0210ItemInfo> itemInfo, String userId)
		{
			this._itemInfo = itemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0210U00SaveLayoutRequest();
		}
	}
}