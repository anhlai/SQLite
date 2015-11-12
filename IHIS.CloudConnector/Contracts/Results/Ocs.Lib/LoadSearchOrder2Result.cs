using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadSearchOrder2Result : AbstractContractResult
	{
		private List<LoadSearchOrderInfo> _searchResult = new List<LoadSearchOrderInfo>();

		public List<LoadSearchOrderInfo> SearchResult
		{
			get { return this._searchResult; }
			set { this._searchResult = value; }
		}

		public LoadSearchOrder2Result() { }

	}
}