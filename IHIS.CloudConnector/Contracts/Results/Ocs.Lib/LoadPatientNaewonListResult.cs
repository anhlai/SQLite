using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadPatientNaewonListResult : AbstractContractResult
	{
		private List<LoadPatientNaewonListInfo> _naewonListItem = new List<LoadPatientNaewonListInfo>();

		public List<LoadPatientNaewonListInfo> NaewonListItem
		{
			get { return this._naewonListItem; }
			set { this._naewonListItem = value; }
		}

		public LoadPatientNaewonListResult() { }

	}
}