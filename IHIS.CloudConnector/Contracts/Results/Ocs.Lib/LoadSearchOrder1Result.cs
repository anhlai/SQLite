using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadSearchOrder1Result : AbstractContractResult
	{
		private List<LoadSearchOrderInfo> _searchResult = new List<LoadSearchOrderInfo>();

		public List<LoadSearchOrderInfo> SearchResult
		{
			get { return this._searchResult; }
			set { this._searchResult = value; }
		}

		public LoadSearchOrder1Result() { }

	}
}