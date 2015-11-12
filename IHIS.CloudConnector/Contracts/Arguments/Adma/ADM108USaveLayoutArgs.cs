using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ADM108UGrdListItemInfo = IHIS.CloudConnector.Contracts.Models.Adma.ADM108UGrdListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM108USaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<ADM108UGrdListItemInfo> _grdListItemInfo = new List<ADM108UGrdListItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<ADM108UGrdListItemInfo> GrdListItemInfo
		{
			get { return this._grdListItemInfo; }
			set { this._grdListItemInfo = value; }
		}

		public ADM108USaveLayoutArgs() { }

		public ADM108USaveLayoutArgs(String userId, List<ADM108UGrdListItemInfo> grdListItemInfo)
		{
			this._userId = userId;
			this._grdListItemInfo = grdListItemInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM108USaveLayoutRequest();
		}
	}
}