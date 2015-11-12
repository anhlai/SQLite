using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetFindWorkerResult : AbstractContractResult
	{
		private List<GetFindWorkerResponseInfo> _info1 = new List<GetFindWorkerResponseInfo>();

		public List<GetFindWorkerResponseInfo> Info1
		{
			get { return this._info1; }
			set { this._info1 = value; }
		}

		public GetFindWorkerResult() { }

	}
}