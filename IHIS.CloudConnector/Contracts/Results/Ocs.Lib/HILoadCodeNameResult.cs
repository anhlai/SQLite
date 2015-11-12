using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class HILoadCodeNameResult : AbstractContractResult
	{
		private List<HILoadCodeNameInfo> _codeNameItem = new List<HILoadCodeNameInfo>();

		public List<HILoadCodeNameInfo> CodeNameItem
		{
			get { return this._codeNameItem; }
			set { this._codeNameItem = value; }
		}

		public HILoadCodeNameResult() { }

	}
}