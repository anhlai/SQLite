using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocsa;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS3003Q10GrdOrderResult : AbstractContractResult
	{
		private List<OCS3003Q10GrdOrderListItemInfo> _listResult = new List<OCS3003Q10GrdOrderListItemInfo>();

		public List<OCS3003Q10GrdOrderListItemInfo> ListResult
		{
			get { return this._listResult; }
			set { this._listResult = value; }
		}

		public OCS3003Q10GrdOrderResult() { }

	}
}