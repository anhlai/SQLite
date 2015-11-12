using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadOftenUsedResult : AbstractContractResult
	{
		private List<LoadOftenUsedResponseInfo> _usedInfo = new List<LoadOftenUsedResponseInfo>();

		public List<LoadOftenUsedResponseInfo> UsedInfo
		{
			get { return this._usedInfo; }
			set { this._usedInfo = value; }
		}

		public LoadOftenUsedResult() { }

	}
}