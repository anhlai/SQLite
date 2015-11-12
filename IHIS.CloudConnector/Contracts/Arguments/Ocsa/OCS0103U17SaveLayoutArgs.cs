using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0103U13GrdOrderListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0103U13GrdOrderListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103U17SaveLayoutArgs : IContractArgs
	{
		private List<OCS0103U13GrdOrderListInfo> _infoList = new List<OCS0103U13GrdOrderListInfo>();
		private String _userId;

		public List<OCS0103U13GrdOrderListInfo> InfoList
		{
			get { return this._infoList; }
			set { this._infoList = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public OCS0103U17SaveLayoutArgs() { }

		public OCS0103U17SaveLayoutArgs(List<OCS0103U13GrdOrderListInfo> infoList, String userId)
		{
			this._infoList = infoList;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103U17SaveLayoutRequest();
		}
	}
}