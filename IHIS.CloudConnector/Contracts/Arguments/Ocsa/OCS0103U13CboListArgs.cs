using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using ProtoBuf;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Arguments.Ocsa
{
    [Serializable]
	public class OCS0103U13CboListArgs : IContractArgs
	{
		private List<ComboDataSourceInfo> _comboItemListInfo = new List<ComboDataSourceInfo>();

		public List<ComboDataSourceInfo> ComboItemListInfo
		{
			get { return this._comboItemListInfo; }
			set { this._comboItemListInfo = value; }
		}

		public OCS0103U13CboListArgs() { }

		public OCS0103U13CboListArgs(List<ComboDataSourceInfo> comboItemListInfo)
		{
			this._comboItemListInfo = comboItemListInfo;
		}

		public IExtensible GetRequestInstance()
		{
			return new IHIS.CloudConnector.Messaging.OCS0103U13CboListRequest();
		}
	}
}