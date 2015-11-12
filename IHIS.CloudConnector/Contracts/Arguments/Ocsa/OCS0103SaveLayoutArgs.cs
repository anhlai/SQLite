using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using OCS0103U13GrdOrderListInfo = IHIS.CloudConnector.Contracts.Models.Ocsa.OCS0103U13GrdOrderListInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
	public class OCS0103SaveLayoutArgs : IContractArgs
	{
		private List<OCS0103U13GrdOrderListInfo> _infoList = new List<OCS0103U13GrdOrderListInfo>();
		private String _userId;
		private String _bunho;
		private String _orderDate;

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

		public String Bunho
		{
			get { return this._bunho; }
			set { this._bunho = value; }
		}

		public String OrderDate
		{
			get { return this._orderDate; }
			set { this._orderDate = value; }
		}

		public OCS0103SaveLayoutArgs() { }

		public OCS0103SaveLayoutArgs(List<OCS0103U13GrdOrderListInfo> infoList, String userId, String bunho, String orderDate)
		{
			this._infoList = infoList;
			this._userId = userId;
			this._bunho = bunho;
			this._orderDate = orderDate;
		}

		public IExtensible GetRequestInstance()
		{
			return new OCS0103SaveLayoutRequest();
		}
	}
}