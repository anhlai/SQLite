using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBCheckRegularDrugResult : AbstractContractResult
	{
		private List<OBCheckRegularDrugInfo> _regDrugItem = new List<OBCheckRegularDrugInfo>();

		public List<OBCheckRegularDrugInfo> RegDrugItem
		{
			get { return this._regDrugItem; }
			set { this._regDrugItem = value; }
		}

		public OBCheckRegularDrugResult() { }

	}
}