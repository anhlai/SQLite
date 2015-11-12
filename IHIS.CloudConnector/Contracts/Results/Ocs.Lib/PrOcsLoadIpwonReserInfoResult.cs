using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsLoadIpwonReserInfoResult : AbstractContractResult
	{
		private List<PrOcsLoadIpwonReserInfo> _reserInfoItem = new List<PrOcsLoadIpwonReserInfo>();

		public List<PrOcsLoadIpwonReserInfo> ReserInfoItem
		{
			get { return this._reserInfoItem; }
			set { this._reserInfoItem = value; }
		}

		public PrOcsLoadIpwonReserInfoResult() { }

	}
}