using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using NUR0101U01GrdDetailInfo = IHIS.CloudConnector.Contracts.Models.Nuri.NUR0101U01GrdDetailInfo;
using NUR0101U01GrdMasterInfo = IHIS.CloudConnector.Contracts.Models.Nuri.NUR0101U01GrdMasterInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Nuri
{
	public class NUR0101U01SaveLayoutArgs : IContractArgs
	{
		private List<NUR0101U01GrdDetailInfo> _grdDetailInfo = new List<NUR0101U01GrdDetailInfo>();
		private List<NUR0101U01GrdMasterInfo> _grdMasterInfo = new List<NUR0101U01GrdMasterInfo>();
		private String _userId;

		public List<NUR0101U01GrdDetailInfo> GrdDetailInfo
		{
			get { return this._grdDetailInfo; }
			set { this._grdDetailInfo = value; }
		}

		public List<NUR0101U01GrdMasterInfo> GrdMasterInfo
		{
			get { return this._grdMasterInfo; }
			set { this._grdMasterInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public NUR0101U01SaveLayoutArgs() { }

		public NUR0101U01SaveLayoutArgs(List<NUR0101U01GrdDetailInfo> grdDetailInfo, List<NUR0101U01GrdMasterInfo> grdMasterInfo, String userId)
		{
			this._grdDetailInfo = grdDetailInfo;
			this._grdMasterInfo = grdMasterInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new NUR0101U01SaveLayoutRequest();
		}
	}
}