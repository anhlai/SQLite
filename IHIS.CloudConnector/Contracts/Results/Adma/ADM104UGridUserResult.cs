using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Adma;

namespace IHIS.CloudConnector.Contracts.Results.Adma
{
	public class ADM104UGridUserResult : AbstractContractResult
	{
		private List<ADM104UGridUserInfo> _gridUserInfo = new List<ADM104UGridUserInfo>();

		public List<ADM104UGridUserInfo> GridUserInfo
		{
			get { return this._gridUserInfo; }
			set { this._gridUserInfo = value; }
		}

		public ADM104UGridUserResult() { }

	}
}