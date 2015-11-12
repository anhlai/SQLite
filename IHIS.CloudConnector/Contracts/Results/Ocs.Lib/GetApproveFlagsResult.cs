using System;
using IHIS.CloudConnector.Contracts.Models.System;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
    [Serializable]
	public class GetApproveFlagsResult : AbstractContractResult
	{
		private ComboListItemInfo _postapproveVisibleInfo;
		private ComboListItemInfo _approveForceInfo;

		public ComboListItemInfo PostapproveVisibleInfo
		{
			get { return this._postapproveVisibleInfo; }
			set { this._postapproveVisibleInfo = value; }
		}

		public ComboListItemInfo ApproveForceInfo
		{
			get { return this._approveForceInfo; }
			set { this._approveForceInfo = value; }
		}

		public GetApproveFlagsResult() { }

	}
}