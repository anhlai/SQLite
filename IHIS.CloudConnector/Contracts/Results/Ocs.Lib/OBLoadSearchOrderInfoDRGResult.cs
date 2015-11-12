using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBLoadSearchOrderInfoDRGResult : AbstractContractResult
	{
		private List<OBLoadSearchOrderInfoDRGInfo> _searchOrderDrgItem = new List<OBLoadSearchOrderInfoDRGInfo>();

		public List<OBLoadSearchOrderInfoDRGInfo> SearchOrderDrgItem
		{
			get { return this._searchOrderDrgItem; }
			set { this._searchOrderDrgItem = value; }
		}

		public OBLoadSearchOrderInfoDRGResult() { }

	}
}