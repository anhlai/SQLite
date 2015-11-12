using System;
using System.Collections.Generic;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class OBGetJundaTable1Result : AbstractContractResult
	{
		private List<OBGetJundaTable1Info> _jundalTableItem = new List<OBGetJundaTable1Info>();

		public List<OBGetJundaTable1Info> JundalTableItem
		{
			get { return this._jundalTableItem; }
			set { this._jundalTableItem = value; }
		}

		public OBGetJundaTable1Result() { }

	}
}