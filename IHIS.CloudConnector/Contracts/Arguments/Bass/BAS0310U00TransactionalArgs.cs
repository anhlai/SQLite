using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using BAS0310U00GrdListItemInfo = IHIS.CloudConnector.Contracts.Models.Bass.BAS0310U00GrdListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0310U00TransactionalArgs : IContractArgs
	{
		private List<BAS0310U00GrdListItemInfo> _listInputInfo = new List<BAS0310U00GrdListItemInfo>();
		private String _userId;

		public List<BAS0310U00GrdListItemInfo> ListInputInfo
		{
			get { return this._listInputInfo; }
			set { this._listInputInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public BAS0310U00TransactionalArgs() { }

		public BAS0310U00TransactionalArgs(List<BAS0310U00GrdListItemInfo> listInputInfo, String userId)
		{
			this._listInputInfo = listInputInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0310U00TransactionalRequest();
		}
	}
}