using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class FnInpLoadJaewonIlsuResult : AbstractContractResult
	{
		private List<FnInpLoadJaewonIlsuInfo> _lsuItem = new List<FnInpLoadJaewonIlsuInfo>();
		private String _retVal;

		public List<FnInpLoadJaewonIlsuInfo> LsuItem
		{
			get { return this._lsuItem; }
			set { this._lsuItem = value; }
		}

		public String RetVal
		{
			get { return this._retVal; }
			set { this._retVal = value; }
		}

		public FnInpLoadJaewonIlsuResult() { }

	}
}