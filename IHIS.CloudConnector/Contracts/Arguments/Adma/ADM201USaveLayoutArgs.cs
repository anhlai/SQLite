using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using ADM201UGrdDicDetailItemInfo = IHIS.CloudConnector.Contracts.Models.Adma.ADM201UGrdDicDetailItemInfo;
using ADM201UGrdDicMasterItemInfo = IHIS.CloudConnector.Contracts.Models.Adma.ADM201UGrdDicMasterItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Adma
{
	public class ADM201USaveLayoutArgs : IContractArgs
	{
		private String _userId;
		private List<ADM201UGrdDicMasterItemInfo> _grdDicMasterItemInfo = new List<ADM201UGrdDicMasterItemInfo>();
		private List<ADM201UGrdDicDetailItemInfo> _grdDicDetailItemInfo = new List<ADM201UGrdDicDetailItemInfo>();

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public List<ADM201UGrdDicMasterItemInfo> GrdDicMasterItemInfo
		{
			get { return this._grdDicMasterItemInfo; }
			set { this._grdDicMasterItemInfo = value; }
		}

		public List<ADM201UGrdDicDetailItemInfo> GrdDicDetailItemInfo
		{
			get { return this._grdDicDetailItemInfo; }
			set { this._grdDicDetailItemInfo = value; }
		}

		public ADM201USaveLayoutArgs() { }

		public ADM201USaveLayoutArgs(String userId, List<ADM201UGrdDicMasterItemInfo> grdDicMasterItemInfo, List<ADM201UGrdDicDetailItemInfo> grdDicDetailItemInfo)
		{
			this._userId = userId;
			this._grdDicMasterItemInfo = grdDicMasterItemInfo;
			this._grdDicDetailItemInfo = grdDicDetailItemInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new ADM201USaveLayoutRequest();
		}
	}
}