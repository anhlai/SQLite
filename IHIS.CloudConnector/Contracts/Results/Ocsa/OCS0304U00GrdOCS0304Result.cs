using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocsa;

namespace IHIS.CloudConnector.Contracts.Results.Ocsa
{
	public class OCS0304U00GrdOCS0304Result : AbstractContractResult
	{
		private List<OcsaOCS0304U00GrdOCS0304ListInfo> _listInfo = new List<OcsaOCS0304U00GrdOCS0304ListInfo>();

		public List<OcsaOCS0304U00GrdOCS0304ListInfo> ListInfo
		{
			get { return this._listInfo; }
			set { this._listInfo = value; }
		}

		public OCS0304U00GrdOCS0304Result() { }

	}
}