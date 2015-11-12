using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    [Serializable]
	public class LoadComboDataSourceResult : AbstractContractResult
	{
		private List<ComboListItemInfo> _dataInfo = new List<ComboListItemInfo>();

		public List<ComboListItemInfo> DataInfo
		{
			get { return this._dataInfo; }
			set { this._dataInfo = value; }
		}

		public LoadComboDataSourceResult() { }

	}
}