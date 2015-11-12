using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Bass;

namespace IHIS.CloudConnector.Contracts.Results.Bass
{
	public class BAS0001U00GrdBAS0001Result : AbstractContractResult
	{
		private List<BAS0001U00GrdBAS0001Info> _itemInfo = new List<BAS0001U00GrdBAS0001Info>();

		public List<BAS0001U00GrdBAS0001Info> ItemInfo
		{
			get { return this._itemInfo; }
			set { this._itemInfo = value; }
		}

		public BAS0001U00GrdBAS0001Result() { }

	}
}