using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsLoadNaewonInfoResult : AbstractContractResult
	{
		private List<PrOcsLoadNaewonInfo> _naewonItem = new List<PrOcsLoadNaewonInfo>();

		public List<PrOcsLoadNaewonInfo> NaewonItem
		{
			get { return this._naewonItem; }
			set { this._naewonItem = value; }
		}

		public PrOcsLoadNaewonInfoResult() { }

	}
}