using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class HIOcsCheckJundalPartLoadJaeryoJundalResult : AbstractContractResult
	{
		private List<HIOcsCheckJundalPartLoadJaeryoJundalInfo> _checkJundalItem = new List<HIOcsCheckJundalPartLoadJaeryoJundalInfo>();

		public List<HIOcsCheckJundalPartLoadJaeryoJundalInfo> CheckJundalItem
		{
			get { return this._checkJundalItem; }
			set { this._checkJundalItem = value; }
		}

		public HIOcsCheckJundalPartLoadJaeryoJundalResult() { }

	}
}