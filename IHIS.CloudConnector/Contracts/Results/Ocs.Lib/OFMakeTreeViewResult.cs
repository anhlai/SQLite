using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OFMakeTreeViewResult : AbstractContractResult
	{
		private List<OFMakeTreeViewInfo> _treeViewItem = new List<OFMakeTreeViewInfo>();

		public List<OFMakeTreeViewInfo> TreeViewItem
		{
			get { return this._treeViewItem; }
			set { this._treeViewItem = value; }
		}

		public OFMakeTreeViewResult() { }

	}
}