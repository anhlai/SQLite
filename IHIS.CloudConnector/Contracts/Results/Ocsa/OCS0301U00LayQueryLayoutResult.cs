using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocsa;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS0301U00LayQueryLayoutResult : AbstractContractResult
	{
		private List<OCS0301U00LayoutInfo> _layoutInfo = new List<OCS0301U00LayoutInfo>();

		public List<OCS0301U00LayoutInfo> LayoutInfo
		{
			get { return this._layoutInfo; }
			set { this._layoutInfo = value; }
		}

		public OCS0301U00LayQueryLayoutResult() { }

	}
}