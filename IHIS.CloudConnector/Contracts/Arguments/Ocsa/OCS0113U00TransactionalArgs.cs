using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0113U00GrdOCS0113ListItemInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0113U00GrdOCS0113ListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0113U00TransactionalArgs : IContractArgs
	{
		private List<OCS0113U00GrdOCS0113ListItemInfo> _listItem = new List<OCS0113U00GrdOCS0113ListItemInfo>();
		private String _userId;

		public List<OCS0113U00GrdOCS0113ListItemInfo> ListItem
		{
			get { return this._listItem; }
			set { this._listItem = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0113U00TransactionalArgs() { }

		public OCS0113U00TransactionalArgs(List<OCS0113U00GrdOCS0113ListItemInfo> listItem, String userId)
		{
			this._listItem = listItem;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0113U00TransactionalRequest();
		}
	}
}