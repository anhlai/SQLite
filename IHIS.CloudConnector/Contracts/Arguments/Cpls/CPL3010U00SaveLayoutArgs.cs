using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Messaging;
using ProtoBuf;
using CPL3010U00GrdGumListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3010U00GrdGumListItemInfo;
using CPL3010U00GrdPartListItemInfo = IHIS.CloudConnector.Contracts.Models.Cpls.CPL3010U00GrdPartListItemInfo;

namespace IHIS.CloudConnector.Contracts.Arguments.Cpls
{
	public class CPL3010U00SaveLayoutArgs : IContractArgs
	{
		private List<CPL3010U00GrdPartListItemInfo> _grdPartInfo = new List<CPL3010U00GrdPartListItemInfo>();
		private List<CPL3010U00GrdGumListItemInfo> _grdGumInfo = new List<CPL3010U00GrdGumListItemInfo>();
		private String _userId;

		public List<CPL3010U00GrdPartListItemInfo> GrdPartInfo
		{
			get { return this._grdPartInfo; }
			set { this._grdPartInfo = value; }
		}

		public List<CPL3010U00GrdGumListItemInfo> GrdGumInfo
		{
			get { return this._grdGumInfo; }
			set { this._grdGumInfo = value; }
		}

		public String UserId
		{
			get { return this._userId; }
			set { this._userId = value; }
		}

		public CPL3010U00SaveLayoutArgs() { }

		public CPL3010U00SaveLayoutArgs(List<CPL3010U00GrdPartListItemInfo> grdPartInfo, List<CPL3010U00GrdGumListItemInfo> grdGumInfo, String userId)
		{
			this._grdPartInfo = grdPartInfo;
			this._grdGumInfo = grdGumInfo;
			this._userId = userId;
		}

		public IExtensible GetRequestInstance()
		{
			return new CPL3010U00SaveLayoutRequest();
		}
	}
}