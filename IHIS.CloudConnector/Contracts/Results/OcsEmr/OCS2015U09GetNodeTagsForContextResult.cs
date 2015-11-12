using System;
using IHIS.CloudConnector.Contracts.Models.OcsEmr;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.OcsEmr
{
    public class OCS2015U09GetNodeTagsForContextResult : AbstractContractResult
	{
		private List<OCS2015U09GetTagsForContextInfo> _rootTagList = new List<OCS2015U09GetTagsForContextInfo>();

		public List<OCS2015U09GetTagsForContextInfo> RootTagList
		{
			get { return this._rootTagList; }
			set { this._rootTagList = value; }
		}

		public OCS2015U09GetNodeTagsForContextResult() { }

	}
}