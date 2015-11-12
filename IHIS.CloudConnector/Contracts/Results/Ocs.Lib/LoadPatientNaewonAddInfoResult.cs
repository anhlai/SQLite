using System;
using IHIS.CloudConnector.Contracts.Models.Ocs.Lib;
using System.Collections.Generic;

namespace IHIS.CloudConnector.Contracts.Results.Ocs.Lib
{
	public class LoadPatientNaewonAddInfoResult : AbstractContractResult
	{
		private String _spFlag;
		private List<LoadPatientNaewonAddInfo> _patientAddInfo = new List<LoadPatientNaewonAddInfo>();
		private String _retVal;

		public String SpFlag
		{
			get { return this._spFlag; }
			set { this._spFlag = value; }
		}

		public List<LoadPatientNaewonAddInfo> PatientAddInfo
		{
			get { return this._patientAddInfo; }
			set { this._patientAddInfo = value; }
		}

		public String RetVal
		{
			get { return this._retVal; }
			set { this._retVal = value; }
		}

		public LoadPatientNaewonAddInfoResult() { }

	}
}