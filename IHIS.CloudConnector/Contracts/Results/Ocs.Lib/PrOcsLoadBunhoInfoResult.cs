using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class PrOcsLoadBunhoInfoResult : AbstractContractResult
	{
		private List<LoadPatientBaseInfo> _patientBaseInfo = new List<LoadPatientBaseInfo>();

		public List<LoadPatientBaseInfo> PatientBaseInfo
		{
			get { return this._patientBaseInfo; }
			set { this._patientBaseInfo = value; }
		}

		public PrOcsLoadBunhoInfoResult() { }

	}
}