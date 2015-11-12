using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using IHIS.CloudConnector.Contracts.Models.System;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OFFormSetMakeFormLoadResult : AbstractContractResult
	{
		private List<ComboListItemInfo> _userComboItem = new List<ComboListItemInfo>();
		private List<ComboListItemInfo> _gwaComboItem = new List<ComboListItemInfo>();
		private List<OFMakeTreeViewInfo> _treeViewItem = new List<OFMakeTreeViewInfo>();

		public List<ComboListItemInfo> UserComboItem
		{
			get { return this._userComboItem; }
			set { this._userComboItem = value; }
		}

		public List<ComboListItemInfo> GwaComboItem
		{
			get { return this._gwaComboItem; }
			set { this._gwaComboItem = value; }
		}

		public List<OFMakeTreeViewInfo> TreeViewItem
		{
			get { return this._treeViewItem; }
			set { this._treeViewItem = value; }
		}

		public OFFormSetMakeFormLoadResult() { }

	}
}