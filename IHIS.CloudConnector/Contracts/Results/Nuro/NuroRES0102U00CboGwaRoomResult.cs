using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Results.Nuro
{
	public class NuroRES0102U00CboGwaRoomResult : AbstractContractResult
	{
		private List<ComboListItemInfo> _cboItemList = new List<ComboListItemInfo>();

		public List<ComboListItemInfo> CboItemList
		{
			get { return this._cboItemList; }
			set { this._cboItemList = value; }
		}

		public NuroRES0102U00CboGwaRoomResult() { }

	}
}