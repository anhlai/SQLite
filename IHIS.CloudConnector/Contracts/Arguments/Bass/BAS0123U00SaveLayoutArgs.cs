using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using BAS0123U00GrdBAS0123Info = IHIS.CloudConnector.Contracts.Models.Bass.BAS0123U00GrdBAS0123Info;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0123U00SaveLayoutArgs : IContractArgs
	{
		private List<BAS0123U00GrdBAS0123Info> _itemInfo = new List<BAS0123U00GrdBAS0123Info>();
		private String _userId;

		public List<BAS0123U00GrdBAS0123Info> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public BAS0123U00SaveLayoutArgs() { }

		public BAS0123U00SaveLayoutArgs(List<BAS0123U00GrdBAS0123Info> itemInfo, String userId)
		{
			this._itemInfo = itemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0123U00SaveLayoutRequest();
		}
	}
}