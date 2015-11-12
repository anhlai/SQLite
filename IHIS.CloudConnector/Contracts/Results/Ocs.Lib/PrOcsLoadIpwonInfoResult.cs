using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsLoadIpwonInfoResult : AbstractContractResult
	{
		private List<PrOcsLoadIpwonInfo> _ipwonInfoItem = new List<PrOcsLoadIpwonInfo>();

		public List<PrOcsLoadIpwonInfo> IpwonInfoItem
		{
			get { return this._ipwonInfoItem; }
			set { this._ipwonInfoItem = value; }
		}

		public PrOcsLoadIpwonInfoResult() { }

	}
}