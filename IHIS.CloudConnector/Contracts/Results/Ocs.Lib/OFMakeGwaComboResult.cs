using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OFMakeGwaComboResult : AbstractContractResult
	{
		private List<ComboListItemInfo> _gwaComboItem = new List<ComboListItemInfo>();

		public List<ComboListItemInfo> GwaComboItem
		{
			get { return this._gwaComboItem; }
			set { this._gwaComboItem = value; }
		}

		public OFMakeGwaComboResult() { }

	}
}