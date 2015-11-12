using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocsa;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS0113U00GrdOCS0113Result : AbstractContractResult
	{
		private List<OCS0113U00GrdOCS0113ListItemInfo> _listGrd = new List<OCS0113U00GrdOCS0113ListItemInfo>();

		public List<OCS0113U00GrdOCS0113ListItemInfo> ListGrd
		{
			get { return this._listGrd; }
			set { this._listGrd = value; }
		}

		public OCS0113U00GrdOCS0113Result() { }

	}
}