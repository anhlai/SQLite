using System;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OFMakeUserComboResult : AbstractContractResult
	{
		private List<ComboListItemInfo> _userComboItem = new List<ComboListItemInfo>();

		public List<ComboListItemInfo> UserComboItem
		{
			get { return this._userComboItem; }
			set { this._userComboItem = value; }
		}

		public OFMakeUserComboResult() { }

	}
}