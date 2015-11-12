using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class HIOcsSpecificCommentResult : AbstractContractResult
	{
		private List<HIOcsSpecificCommentInfo> _specCommentItem = new List<HIOcsSpecificCommentInfo>();

		public List<HIOcsSpecificCommentInfo> SpecCommentItem
		{
			get { return this._specCommentItem; }
			set { this._specCommentItem = value; }
		}

		public HIOcsSpecificCommentResult() { }

	}
}