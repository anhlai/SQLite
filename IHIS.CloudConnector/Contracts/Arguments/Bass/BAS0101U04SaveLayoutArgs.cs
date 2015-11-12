using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using BAS0101U04GrdDetailInfo = IHIS.CloudConnector.Contracts.Models.Bass.BAS0101U04GrdDetailInfo;
using BAS0101U04GrdMasterInfo = IHIS.CloudConnector.Contracts.Models.Bass.BAS0101U04GrdMasterInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Bass
{
	public class BAS0101U04SaveLayoutArgs : IContractArgs
	{
		private List<BAS0101U04GrdDetailInfo> _grdDetailInfo = new List<BAS0101U04GrdDetailInfo>();
		private List<BAS0101U04GrdMasterInfo> _grdMasterInfo = new List<BAS0101U04GrdMasterInfo>();
		private String _userId;

		public List<BAS0101U04GrdDetailInfo> GrdDetailInfo
		{
			get { return this._grdDetailInfo; }
			set { this._grdDetailInfo = value; }
		}

		public List<BAS0101U04GrdMasterInfo> GrdMasterInfo
		{
			get { return this._grdMasterInfo; }
			set { this._grdMasterInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public BAS0101U04SaveLayoutArgs() { }

		public BAS0101U04SaveLayoutArgs(List<BAS0101U04GrdDetailInfo> grdDetailInfo, List<BAS0101U04GrdMasterInfo> grdMasterInfo, String userId)
		{
			this._grdDetailInfo = grdDetailInfo;
			this._grdMasterInfo = grdMasterInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new BAS0101U04SaveLayoutRequest();
		}
	}
}