using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using DRG0102U01GrdDetailItemInfo = IHIS.CloudConnector.Contracts.Models.Drgs.DRG0102U01GrdDetailItemInfo;
using DRG0102U01GrdMasterItemInfo = IHIS.CloudConnector.Contracts.Models.Drgs.DRG0102U01GrdMasterItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Drgs
{
	public class DRG0102U01SaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<DRG0102U01GrdMasterItemInfo> _grdMasterItemInfo = new List<DRG0102U01GrdMasterItemInfo>();
		private List<DRG0102U01GrdDetailItemInfo> _grdDetailItemInfo = new List<DRG0102U01GrdDetailItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<DRG0102U01GrdMasterItemInfo> GrdMasterItemInfo
		{
			get { return this._grdMasterItemInfo; }
			set { this._grdMasterItemInfo = value; }
		}

		public List<DRG0102U01GrdDetailItemInfo> GrdDetailItemInfo
		{
			get { return this._grdDetailItemInfo; }
			set { this._grdDetailItemInfo = value; }
		}

		public DRG0102U01SaveLayoutArgs() { }

		public DRG0102U01SaveLayoutArgs(String userId, List<DRG0102U01GrdMasterItemInfo> grdMasterItemInfo, List<DRG0102U01GrdDetailItemInfo> grdDetailItemInfo)
		{
			this._userId = userId;
			this._grdMasterItemInfo = grdMasterItemInfo;
			this._grdDetailItemInfo = grdDetailItemInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new DRG0102U01SaveLayoutRequest();
		}
	}
}