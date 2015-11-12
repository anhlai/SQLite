using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using BAS0230U00GrdBas0230Info = IHIS.CloudConnector.Contracts.Models.Bass.BAS0230U00GrdBas0230Info;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0230U00GrdBas0230SaveLayoutArgs : IContractArgs
	{
		private List<BAS0230U00GrdBas0230Info> _itemInfo = new List<BAS0230U00GrdBas0230Info>();
		private String _userId;

		public List<BAS0230U00GrdBas0230Info> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public BAS0230U00GrdBas0230SaveLayoutArgs() { }

		public BAS0230U00GrdBas0230SaveLayoutArgs(List<BAS0230U00GrdBas0230Info> itemInfo, String userId)
		{
			this._itemInfo = itemInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0230U00GrdBas0230SaveLayoutRequest();
		}
	}
}