using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocsa;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsLoadHangmogInfoResult : AbstractContractResult
	{
		private List<LoadHangmogInfo> _hangmogInfoItem = new List<LoadHangmogInfo>();

		public List<LoadHangmogInfo> HangmogInfoItem
		{
			get { return this._hangmogInfoItem; }
			set { this._hangmogInfoItem = value; }
		}

		public PrOcsLoadHangmogInfoResult() { }

	}
}