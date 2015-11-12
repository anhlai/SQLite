using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NUR1017U00GrdNUR1017ListItemInfo = IHIS.CloudConnector.Contracts.Models.Nuri.NUR1017U00GrdNUR1017ListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR1017U00SaveLayoutArgs : IContractArgs
	{
		private List<NUR1017U00GrdNUR1017ListItemInfo> _grdList = new List<NUR1017U00GrdNUR1017ListItemInfo>();
		private String _userId;

		public List<NUR1017U00GrdNUR1017ListItemInfo> GrdList
		{
			get { return this._grdList; }
			set { this._grdList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public NUR1017U00SaveLayoutArgs() { }

		public NUR1017U00SaveLayoutArgs(List<NUR1017U00GrdNUR1017ListItemInfo> grdList, String userId)
		{
			this._grdList = grdList;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR1017U00SaveLayoutRequest();
		}
	}
}