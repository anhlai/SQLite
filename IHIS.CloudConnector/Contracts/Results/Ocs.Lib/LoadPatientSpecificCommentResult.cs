using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadPatientSpecificCommentResult : AbstractContractResult
	{
		private List<DataStringListItemInfo> _listComment = new List<DataStringListItemInfo>();

		public List<DataStringListItemInfo> ListComment
		{
			get { return this._listComment; }
			set { this._listComment = value; }
		}

		public LoadPatientSpecificCommentResult() { }

	}
}