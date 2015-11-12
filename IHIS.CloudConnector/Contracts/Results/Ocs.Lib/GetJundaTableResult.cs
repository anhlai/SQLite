using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetJundaTableResult : AbstractContractResult
	{
		private List<GetJundaTableResponseInfo> _info1 = new List<GetJundaTableResponseInfo>();

		public List<GetJundaTableResponseInfo> Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public GetJundaTableResult() { }

	}
}