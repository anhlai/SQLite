using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ADM501UListItemInfo = IHIS.CloudConnector.Contracts.Models.Adma.ADM501UListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM501USaveLayoutArgs : IContractArgs
	{
		private String _userInfo;
		private List<ADM501UListItemInfo> _listItemInfo = new List<ADM501UListItemInfo>();

		public String UserInfo
		{
			get { return this._userInfo; }
			set { this._userInfo = value; }
		}

		public List<ADM501UListItemInfo> ListItemInfo
		{
			get { return this._listItemInfo; }
			set { this._listItemInfo = value; }
		}

		public ADM501USaveLayoutArgs() { }

		public ADM501USaveLayoutArgs(String userInfo, List<ADM501UListItemInfo> listItemInfo)
		{
			this._userInfo = userInfo;
			this._listItemInfo = listItemInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM501USaveLayoutRequest();
		}
	}
}