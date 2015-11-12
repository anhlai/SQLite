using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class GetDefaultOrdDanui2Result : AbstractContractResult
	{
		private List<GetDefaultOrdDanuiInfo> _danuiItem = new List<GetDefaultOrdDanuiInfo>();

		public List<GetDefaultOrdDanuiInfo> DanuiItem
		{
			get { return this._danuiItem; }
			set { this._danuiItem = value; }
		}

		public GetDefaultOrdDanui2Result() { }

	}
}